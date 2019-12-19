using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebCamCapture
{
    public partial class SettingDevice : Form
    {
        public SettingDevice()
        {
            InitializeComponent();
        }
        Capture capture;
        private void SettingDevice_Load(object sender, EventArgs e)
        {
            capture = new Capture();
            capture.UpdateListNameDevices();
            ListCaptureDevices.Items.AddRange(capture.ListNameDevices.ToArray());
            ListCaptureDevices.SelectedIndex = 0;
            ListCaptutreModes.Items.AddRange(capture.GetVideoModes(ListCaptureDevices.SelectedIndex).ToArray());
        }

        private void ListCaptutreModes_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ListCaptureDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListCaptutreModes.Items.Clear();
            ListCaptutreModes.Items.AddRange(capture.GetVideoModes(ListCaptureDevices.SelectedIndex).ToArray());
        }
    }
}
