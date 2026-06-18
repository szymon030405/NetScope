using SharpPcap;

namespace NetScope
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            var devices = CaptureDeviceList.Instance;
            string output = "";

            foreach (var device in devices)
            {
                output += device.Name + " - " + device.Description + "\n";
            }

            MessageBox.Show(output);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
