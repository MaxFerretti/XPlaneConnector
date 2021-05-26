using System;
using System.Threading;
using System.Windows.Forms;
using XPlaneConnector.DataRefs;

namespace XPlaneConnectorExample
{
    public partial class Form1 : Form
    {
        private XPlaneConnector.XPlaneConnector connector = new XPlaneConnector.XPlaneConnector();
        CancellationTokenSource igniteToken;

        public Form1()
        {
            InitializeComponent();
        }

        private void Log(string text)
        {
            if (InvokeRequired)
                Invoke(new Action(() => Log(text)));
            else
                tbOut.Text = $"{tbOut.Text}{Environment.NewLine}{DateTime.Now:HH:mm:ss.fff} - {text}";
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            connector.Subscribe(DataRefs.CockpitElectricalBatteryOn, 25, (element, value) =>
            {

                Log($"{element.DataRef}: {value}");
            });

            connector.Subscribe(DataRefs.CockpitRadiosNav1FreqHz, 25, (element, value) =>
            {

                Log($"{element.DataRef}: {value}");
            });

            connector.Subscribe(DataRefs.AircraftViewAcfTailnum, 25, (element, value) =>
            {

                Log($"{element.DataRef}: {value}");
            });

            connector.Start();
        }


        private void btBatteryOn_Click(object sender, EventArgs e)
        {
            connector.SendCommand(Commands.ElectricalBattery1On);
        }

        private void btBatteryOff_Click(object sender, EventArgs e)
        {
            connector.SendCommand(Commands.ElectricalBattery1Off);
        }

        private void btNavUp_Click(object sender, EventArgs e)
        {
            connector.SendCommand(Commands.RadiosStbyNav1FineUp);
        }

        private void btNavDown_Click(object sender, EventArgs e)
        {
            connector.SendCommand(Commands.RadiosStbyNav1FineDown);
        }

        private void btQuit_Click(object sender, EventArgs e)
        {
            connector.SendCommand(Commands.OperationQuit);
        }

        private void btnIgnite_Click(object sender, EventArgs e)
        {
            if (igniteToken == null)
            {
                igniteToken = connector.StartCommand(Commands.EnginesEngageStarters);
            } else
            {
                connector.StopCommand(igniteToken);
                igniteToken = null;
            }
        }
    }
}
