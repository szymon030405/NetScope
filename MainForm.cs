using SharpPcap;
using PacketDotNet;
using System;
using System.Windows.Forms;

namespace NetScope
{
    public partial class MainForm : Form
    {
        private ILiveDevice? _device;
        private int _packetCount = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadNetworkInterfaces();
            btnStop.Enabled = false;
        }

        private void LoadNetworkInterfaces()
        {
            var devices = CaptureDeviceList.Instance;

            if (devices.Count == 0)
            {
                MessageBox.Show("No network interfaces found. Make sure Npcap is installed.", "NetScope", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            cmbInterfaces.Items.Clear();

            foreach (var device in devices)
            {
                cmbInterfaces.Items.Add(device.Description);
            }

            cmbInterfaces.SelectedIndex = 0;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbInterfaces.SelectedIndex == -1) return;

                var devices = CaptureDeviceList.Instance;
                _device = devices[cmbInterfaces.SelectedIndex];

                _packetCount = 0;
                dgvPackets.Rows.Clear();

                _device.OnPacketArrival += OnPacketArrival;
                _device.Open(DeviceModes.Promiscuous);
                _device.StartCapture();

                btnStart.Enabled = false;
                btnStop.Enabled = true;
                cmbInterfaces.Enabled = false;

                MessageBox.Show("Capture started on: " + _device.Description);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            StopCapture();
        }

        private void StopCapture()
        {
            if (_device == null) return;

            _device.StopCapture();
            _device.OnPacketArrival -= OnPacketArrival;
            _device.Close();

            btnStart.Enabled = true;
            btnStop.Enabled = false;
            cmbInterfaces.Enabled = true;
        }

        private void OnPacketArrival(object sender, PacketCapture e)
        {
            var rawPacket = e.GetPacket();
            var packet = Packet.ParsePacket(rawPacket.LinkLayerType, rawPacket.Data);

            string srcIp = "-";
            string dstIp = "-";
            string protocol = "Unknown";
            string info = "";

            var ipPacket = packet.Extract<IPPacket>();
            if (ipPacket != null)
            {
                srcIp = ipPacket.SourceAddress.ToString();
                dstIp = ipPacket.DestinationAddress.ToString();
                protocol = ipPacket.Protocol.ToString();

                var tcpPacket = packet.Extract<TcpPacket>();
                if (tcpPacket != null)
                {
                    protocol = "TCP";
                    info = $"Port {tcpPacket.SourcePort} → {tcpPacket.DestinationPort}";
                }

                var udpPacket = packet.Extract<UdpPacket>();
                if (udpPacket != null)
                {
                    protocol = "UDP";
                    info = $"Port {udpPacket.SourcePort} → {udpPacket.DestinationPort}";
                }
            }

            var arpPacket = packet.Extract<ArpPacket>();
            if (arpPacket != null)
            {
                protocol = "ARP";
                srcIp = arpPacket.SenderProtocolAddress.ToString();
                dstIp = arpPacket.TargetProtocolAddress.ToString();
                info = $"{arpPacket.Operation}";
            }

            int count = ++_packetCount;
            string time = rawPacket.Timeval.Date.ToString("HH:mm:ss.fff");
            int length = rawPacket.Data.Length;

            // Must update UI on the UI thread
            this.BeginInvoke(new Action(() =>
            {
                int rowIndex = dgvPackets.Rows.Add(count, time, srcIp, dstIp, protocol, length, info);
                dgvPackets.FirstDisplayedScrollingRowIndex = rowIndex;
            }));
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            StopCapture();
            base.OnFormClosing(e);
        }
    }
}
