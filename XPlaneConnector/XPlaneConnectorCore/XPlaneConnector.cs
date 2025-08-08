using System.Collections.Concurrent;
using System.Globalization;
using System.Net;
using System.Net.Sockets;
using System.Text;

using XPlaneConnectorCore;

namespace XPlaneConnectorCore
{
    public interface IXPlaneConnector : IDisposable
    {
        void Start();
        Task StopAsync(int timeout = 5000);
        Task SendCommandAsync(XPlaneCommand command);
        Task SubscribeAsync(DataRefElement dataref, int frequency = -1, Action<DataRefElement, float>? onchange = null);
        Task SubscribeAsync(StringDataRefElement dataref, int frequency=-1, Action<StringDataRefElement, string>? onchange = null);
        CommandTask StartCommand(XPlaneCommand command, int frequencyHz = 10);
        Task StopCommandAsync(CommandTask commandTask);
        Task SetDataRefValueAsync(DataRefElement dataref, float value);
        Task SetDataRefValueAsync(string dataref, float value);
        Task SetDataRefValueAsync(string dataref, string value);
        Task QuitXPlaneAsync();
        Task FailAsync(int system);
        Task RecoverAsync(int system);
    }

    public class XPlaneConnector : IXPlaneConnector
    {
        private UdpClient server;
        private UdpClient client;
        private CancellationTokenSource ts;
        private Task listenTask;
        private Task observerTask;

        private readonly TimeSpan MaxDataRefAge = TimeSpan.FromSeconds(5);
        private const int CheckInterval_ms = 1000;
        private readonly CultureInfo EnCulture = new CultureInfo("en-US");

        public event Action<string> OnRawReceive;
        public event Action<DataRefElement> OnDataRefReceived;
        public event Action<string> OnLog;

        private readonly ConcurrentDictionary<int, DataRefElement> DataRefs = new();

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="ip">IP of the machine running X-Plane, default 127.0.0.1 (localhost)</param>
        /// <param name="xplanePort">Port the machine running X-Plane is listening for, default 49000</param>
        public XPlaneConnector(string ip = "127.0.0.1", int xplanePort = 49000)
        {
            var xplaneEP = new IPEndPoint(IPAddress.Parse(ip), xplanePort);
            client = new UdpClient();
            client.Connect(xplaneEP);
        }

        /// <summary>
        /// Initialize the communication with X-Plane machine and starts listening for DataRefs
        /// </summary>
        public void Start()
        {
            server = new UdpClient(new IPEndPoint(IPAddress.Any, 0));
            ts = new CancellationTokenSource();
            var token = ts.Token;

            listenTask = ListenAsync(token);
            observerTask = ObserveAsync(token);
        }

        /// <summary>
        /// Stops the comunications with the X-Plane machine
        /// </summary>
        /// <param name="timeout"></param>
        public async Task StopAsync(int timeout = 5000)
        {
            if (client != null)
            {
                if (ts != null)
                {
                    await ts.CancelAsync();
                    await Task.WhenAll(listenTask, observerTask);
                    ts.Dispose();
                }

                foreach (var dr in DataRefs.Values)
                    await UnsubscribeAsync(dr.DataRef);

                server?.Dispose();
                client?.Dispose();
                server = null;
                client = null;
            }
        }



        private async Task ListenAsync(CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                try
                {
                    var response = await server.ReceiveAsync(token);
                    OnRawReceive?.Invoke(Encoding.UTF8.GetString(response.Buffer));
                    ParseResponse(response.Buffer);
                }
                catch (ObjectDisposedException) { }
                catch (Exception ex)
                {
                    OnLog?.Invoke($"Listener error: {ex.Message}");
                }
            }
        }

        private async Task ObserveAsync(CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                foreach (var dr in DataRefs.Values)
                {
                    if (dr.Age > MaxDataRefAge)
                        await RequestDataRefAsync(dr);
                }

                await Task.Delay(CheckInterval_ms, token);
            }
        }

        private void ParseResponse(byte[] buffer)
        {
            var pos = 0;
            var header = Encoding.UTF8.GetString(buffer, pos, 4);
            pos += 5; // Including tailing 0

            if (header == "RREF") // Ignore other messages
            {
                while (pos < buffer.Length)
                {
                    var id = BitConverter.ToInt32(buffer, pos);
                    pos += 4;

                    try
                    {
                        var value = BitConverter.ToSingle(buffer, pos);
                        pos += 4;

                        if(DataRefs.TryGetValue(id, out var dataRef) && dataRef.Update(id, value)) 
                            OnDataRefReceived?.Invoke(dataRef);
                    }
                    catch (Exception ex)
                    {
                        var error = ex.Message;
                    }
                }
            }
        }

        /// <summary>
        /// Sends a command
        /// </summary>
        /// <param name="command">Command to send</param>
        public async Task SendCommandAsync(XPlaneCommand command)
        {
            if (command == null)
                throw new ArgumentNullException(nameof(command));

            var dg = new XPDatagram();
            dg.Add("CMND");
            dg.Add(command.Command);

            await client.SendAsync(dg.Get(), dg.Len);
        }

        /// <summary>
        /// Subscribe to a DataRef, notification will be sent every time the value changes
        /// </summary>
        /// <param name="dataref">DataRef to subscribe to</param>
        /// <param name="frequency">Times per seconds X-Plane will be seding this value</param>
        /// <param name="onchange">Callback invoked every time a change in the value is detected</param>
        public async Task SubscribeAsync(DataRefElement dataref, int frequency = -1, Action<DataRefElement, float>? onchange = null)
        {
            if (dataref == null)
                throw new ArgumentNullException(nameof(dataref));

            if (onchange != null)
                dataref.OnValueChange += (e, v) => { onchange(e, v); };

            if (frequency > 0)
                dataref.Frequency = frequency;

            DataRefs.TryAdd(dataref.Id, dataref);
            await RequestDataRefAsync(dataref);
        }

        /// <summary>
        /// Subscribe to a DataRef, notification will be sent every time the value changes
        /// </summary>
        /// <param name="dataref">DataRef to subscribe to</param>
        /// <param name="frequency">Times per seconds X-Plane will be seding this value</param>
        /// <param name="onchange">Callback invoked every time a change in the value is detected</param>
        public async Task SubscribeAsync(StringDataRefElement dataref, int frequency = -1, Action<StringDataRefElement, string>? onchange = null)
        {
            if (dataref == null)
                throw new ArgumentNullException(nameof(dataref));

            if(onchange != null)    
                dataref.OnValueChange += (e, v) => { onchange(e, v); };

            for (var c = 0; c < dataref.StringLength; c++)
            {
                var arrayElementDataRef = new DataRefElement($"{dataref.DataRef}[{c}]", "", "");

                var currentIndex = c;
                await SubscribeAsync(arrayElementDataRef, frequency, (e, v) =>
                {
                    var character = Convert.ToChar(Convert.ToInt32(v));
                    dataref.Update(currentIndex, character);
                });
            }
        }

        private async Task RequestDataRefAsync(DataRefElement element)
        {
            if (client != null)
            {
                var dg = new XPDatagram();
                dg.Add("RREF");
                dg.Add(element.Frequency);
                dg.Add(element.Id);
                dg.Add(element.DataRef);
                dg.FillTo(413);

                await client.SendAsync(dg.Get(), dg.Len);

                OnLog?.Invoke($"Requested {element.DataRef}@{element.Frequency}Hz with Id:{element.Id}");
            }
        }

        /// <summary>
        /// Informs X-Plane to stop sending this DataRef
        /// </summary>
        /// <param name="dataref">DataRef to unsubscribe to</param>
        public async Task UnsubscribeAsync(string dataref)
        {
            var toRemove = DataRefs.Values.Where(d => d.DataRef == dataref).ToList();

            foreach (var dr in toRemove)
            {
                var dg = new XPDatagram();
                dg.Add("RREF");
                dg.Add(dr.Id);
                dg.Add(0);
                dg.Add(dataref);
                dg.FillTo(413);

                await client.SendAsync(dg.Get(), dg.Len);
                DataRefs.TryRemove(dr.Id, out _);

                OnLog?.Invoke($"Unsubscribed from {dataref}");
            }
        }

        protected virtual void Dispose(bool a)
        {
            ts?.Cancel();
            ts?.Dispose();
            server?.Dispose();
            client?.Dispose();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Sends a command continously. Use return parameter to cancel the send cycle
        /// </summary>
        /// <param name="command">Command to send</param>
        /// <returns>Token to cancel the executing</returns>
        public CommandTask StartCommand(XPlaneCommand command, int frequencyHz = 10)
        {
            if (command == null) throw new ArgumentNullException(nameof(command));
            if (frequencyHz <= 0) throw new ArgumentOutOfRangeException(nameof(frequencyHz));

            var tokenSource = new CancellationTokenSource();
            var token = tokenSource.Token;
            var interval = TimeSpan.FromMilliseconds(1000.0 / frequencyHz);

            var task = Task.Run(async () =>
            {
                while (!token.IsCancellationRequested)
                {
                    try
                    {
                        await SendCommandAsync(command);
                        await Task.Delay(interval, token);
                    }
                    catch (OperationCanceledException)
                    {
                        // Normal shutdown
                    }
                    catch (Exception ex)
                    {
                        OnLog?.Invoke($"Error in StartCommand loop: {ex.Message}");
                    }
                }
            }, token);

            return new CommandTask(tokenSource, task);
        }

        public async Task StopCommandAsync(CommandTask commandTask)
        {
            if (commandTask == null) return;

            await commandTask.StopAsync();
        }

        /// <summary>
        /// Informs X-Plane to change the value of the DataRef
        /// </summary>
        /// <param name="dataref">DataRef that will be changed</param>
        /// <param name="value">New value of the DataRef</param>
        public async Task SetDataRefValueAsync(DataRefElement dataref, float value)
        {
            if (dataref == null)
                throw new ArgumentNullException(nameof(dataref));

            await SetDataRefValueAsync(dataref.DataRef, value);
        }

        /// <summary>
        /// Informs X-Plane to change the value of the DataRef
        /// </summary>
        /// <param name="dataref">DataRef that will be changed</param>
        /// <param name="value">New value of the DataRef</param>
        public async Task SetDataRefValueAsync(string dataref, float value)
        {
            var dg = new XPDatagram();
            dg.Add("DREF");
            dg.Add(value);
            dg.Add(dataref);
            dg.FillTo(509);

            await client.SendAsync(dg.Get(), dg.Len);
        }
        /// <summary>
        /// Informs X-Plane to change the value of the DataRef
        /// </summary>
        /// <param name="dataref">DataRef that will be changed</param>
        /// <param name="value">New value of the DataRef</param>
        public async Task SetDataRefValueAsync(string dataref, string value)
        {
            var dg = new XPDatagram();
            dg.Add("DREF");
            dg.Add(value);
            dg.Add(dataref);
            dg.FillTo(509);

            await client.SendAsync(dg.Get(), dg.Len);
        }

        /// <summary>
        /// Request X-Plane to close, a notification message will appear
        /// </summary>
        public async Task QuitXPlaneAsync()
        {
            var dg = new XPDatagram();
            dg.Add("QUIT");

            await client.SendAsync(dg.Get(), dg.Len);
        }

        /// <summary>
        /// Inform X-Plane that a system is failed
        /// </summary>
        /// <param name="system">Integer value representing the system to fail</param>
        public async Task FailAsync(int system)
        {
            var dg = new XPDatagram();
            dg.Add("FAIL");

            dg.Add(system.ToString(EnCulture));

            await client.SendAsync(dg.Get(), dg.Len);
        }

        /// <summary>
        /// Inform X-Plane that a system is back to normal functioning
        /// </summary>
        /// <param name="system">Integer value representing the system to recover</param>
        public async Task RecoverAsync(int system)
        {
            var dg = new XPDatagram();
            dg.Add("RECO");

            dg.Add(system.ToString(EnCulture));

            await client.SendAsync(dg.Get(), dg.Len);
        }


    }
}
