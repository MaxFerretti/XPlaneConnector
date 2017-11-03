using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace XPlaneConnector
{
    public class XPlaneConnector
    {
        public int CheckInterval_ms = 1000;
        public TimeSpan MaxDataRefAge = TimeSpan.FromSeconds(5);

        private UdpClient client;
        private IPEndPoint XPlaneEP;
        private CancellationTokenSource ts;
        private Task serverTask;
        private Task observerTask;

        public delegate void RawReceiveHandler(string raw);
        public event RawReceiveHandler OnRawReceive;

        public delegate void DataRefReceived(string dataref, float value);
        public event DataRefReceived OnDataRefReceived;

        public delegate void LogHandler(string message);
        public event LogHandler OnLog;

        private List<DataRefElement> dataRefs;
        private int current_id;

        public DateTime LastReceive { get; internal set; }
        public byte[] LastBuffer { get; internal set; }
        public IPEndPoint LocalEP
        {
            get
            {
                return ((IPEndPoint)client.Client.LocalEndPoint);
            }
        }
        public XPlaneConnector(string ip, int xplanePort)
        {

            XPlaneEP = new IPEndPoint(IPAddress.Parse(ip), xplanePort);
            dataRefs = new List<DataRefElement>();
            current_id = 0;
        }
        public void Start()
        {
            client = new UdpClient();
            client.Connect(XPlaneEP.Address, XPlaneEP.Port);

            var server = new UdpClient(LocalEP);

            ts = new CancellationTokenSource();
            var token = ts.Token;

            serverTask = Task.Factory.StartNew(async () =>
            {
                while (!token.IsCancellationRequested)
                {
                    var response = await server.ReceiveAsync();
                    var raw = Encoding.UTF8.GetString(response.Buffer);
                    LastReceive = DateTime.Now;
                    LastBuffer = response.Buffer;

                    OnRawReceive?.Invoke(raw);
                    ParseResponse(response.Buffer);
                }

                OnLog?.Invoke("Stopping server");
                server.Close();
            }, token, TaskCreationOptions.LongRunning, TaskScheduler.Default);

            observerTask = Task.Factory.StartNew(async () =>
            {
                while (!token.IsCancellationRequested)
                {
                    foreach (var dr in dataRefs)
                        if (dr.Age > MaxDataRefAge)
                            RequestDataRef(dr);

                    await Task.Delay(CheckInterval_ms);
                }

            }, token, TaskCreationOptions.LongRunning, TaskScheduler.Default);
        }
        public void Stop(int timeout = 5000)
        {
            if (client != null)
            {
                foreach (var dr in dataRefs)
                    Unsubscribe(dr.DataRef);

                if (ts != null)
                {
                    ts.Cancel();
                    Task.WaitAll(new[] { serverTask, observerTask }, timeout);
                    ts.Dispose();
                    ts = null;

                    client.Close();
                }
            }
        }
        private void ParseResponse(byte[] buffer)
        {
            var pos = 0;
            var header = Encoding.UTF8.GetString(buffer, pos, 4);
            pos += 5; // Including tailing 0

            while (pos < buffer.Length)
            {
                if (header == "RREF")
                {
                    var id = BitConverter.ToInt32(buffer, pos);
                    pos += 4;

                    var value = BitConverter.ToSingle(buffer, pos);
                    pos += 4;

                    var dataref = dataRefs.SingleOrDefault((dr => dr.Id == id));

                    if (dataref != null)
                    {
                        if (dataref.Update(value))
                            OnDataRefReceived?.Invoke(dataref.DataRef, value);
                    }
                }
            }
        }
        public void SendCommand(string command)
        {
            var dg = new XPDatagram();
            dg.Add("CMND");
            dg.Add(command);

            client.Send(dg.Get(), dg.Len);
        }
        public void Subscribe(string dataref, int frequency, Action<DataRefElement, float> onchange = null)
        {
            var dr = new DataRefElement
            {
                Id = ++current_id,
                DataRef = dataref,
                Frequency = frequency,
                CurrentValue = Single.MinValue
            };

            if (onchange != null)
                dr.OnValueChange += (e, v) => { onchange(e, v); };
            dataRefs.Add(dr);
        }
        private void RequestDataRef(DataRefElement element)
        {
            if (client != null)
            {
                var dg = new XPDatagram();
                dg.Add("RREF");
                dg.Add(element.Frequency);
                dg.Add(element.Id);
                dg.Add(element.DataRef);
                dg.FillTo(413);

                client.Send(dg.Get(), dg.Len);

                OnLog?.Invoke($"Requested {element.DataRef}@{element.Frequency}Hz with Id:{element.Id}");
            }
        }
        public void Unsubscribe(string dataref)
        {
            var dr = dataRefs.SingleOrDefault(d => d.DataRef == dataref);
            var id = 0;

            if (dr != null)
                id = dr.Id;
            else
                id = ++current_id;

            var dg = new XPDatagram();
            dg.Add("RREF");
            dg.Add(id);
            dg.Add(0);
            dg.Add(dataref);
            dg.FillTo(413);

            client.Send(dg.Get(), dg.Len);

            OnLog?.Invoke($"Unsubscribed from {dataref}");
        }
        public void SetDataRefValue(string dataref, float value)
        {
            var dg = new XPDatagram();
            dg.Add("DREF");
            dg.Add(value);
            dg.Add(dataref);
            dg.FillTo(509);

            client.Send(dg.Get(), dg.Len);
        }
        public float GetDataRefValue(string dataref)
        {
            var dr = dataRefs.SingleOrDefault(d => d.DataRef == dataref);

            if (dr != null)
                return dr.CurrentValue;

            return 0;
        }
        public void QuitXPlane()
        {
            var dg = new XPDatagram();
            dg.Add("QUIT");

            client.Send(dg.Get(), dg.Len);
        }
        public void Fail(int system)
        {
            var dg = new XPDatagram();
            dg.Add("FAIL");

            dg.Add(system.ToString());

            client.Send(dg.Get(), dg.Len);
        }
        public void Recover(int system)
        {
            var dg = new XPDatagram();
            dg.Add("RECO");

            dg.Add(system.ToString());

            client.Send(dg.Get(), dg.Len);
        }
    }
}
