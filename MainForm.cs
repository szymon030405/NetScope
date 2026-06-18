using SharpPcap;

namespace NetScope
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadNetworkInterfaces();
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
    }
}
