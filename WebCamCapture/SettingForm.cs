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
    public partial class SettingForm : Form
    {
        Capture capture;
        public SettingForm()
        {
            InitializeComponent();
            capture = new Capture();
        }
        
        private void SettingDevice_Load(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = Properties.Settings.Default.FileDir;
            SettinAppPanel__FileDirView.Text = folderBrowserDialog1.SelectedPath;
            capture.UpdateListNameDevices();
            if (capture.DevicesCounter > 0)
            {
                ListCaptureDevices.Items.AddRange(capture.ListNameDevices.ToArray());
                ListCaptureDevices.SelectedIndex = capture.DeviceId;
            }

            ListCaptutreModes.Items.Clear();
            capture.UpdateListVideoModes(ListCaptureDevices.SelectedIndex);
            ListCaptutreModes.Items.AddRange(capture.ListVideoModes.ToArray());
            ListCaptutreModes.SelectedIndex = capture.ModeId;     
        }

        /// <summary>
        /// выбор устройства из выподающего списка ListCaptureDevices
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListCaptureDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListCaptutreModes.Items.Clear();
            capture.UpdateListVideoModes(ListCaptureDevices.SelectedIndex);
            // заполняем список доступных разрешений 
            ListCaptutreModes.Items.AddRange(capture.ListVideoModes.ToArray());
        }

        private string dev;
        private int mod;

        public string Dev { get => dev; set => dev = value; }
        public int Mod { get => mod; set => mod = value; }



        private void BtnOkSettingDev_Click(object sender, EventArgs e)
        {
            dev = ListCaptureDevices.SelectedItem.ToString();
            mod = ListCaptutreModes.SelectedIndex;
        }

        private void SettingAppPanel__DirOkBtn_Click(object sender, EventArgs e)
        {
            
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {

                SettinAppPanel__FileDirView.Text = folderBrowserDialog1.SelectedPath;
                Properties.Settings.Default.FileDir = folderBrowserDialog1.SelectedPath;
                //Properties.Settings.Default.Save();
            }
        }

        private void ListCaptutreModes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //capture.ModeId = ListCaptutreModes.SelectedIndex;
            
        }
    }
}
