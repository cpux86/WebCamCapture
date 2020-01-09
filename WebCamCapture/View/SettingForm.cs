using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebCamCapture.View
{
    public partial class SettingForm : Form, ISetting
    {
        public SettingForm()
        {
            InitializeComponent();
            btnOkSettingDev.Click += BtnOkSettingDev_Click;
        }


        /// <summary>
        /// выбор устройства из выподающего списка ListCaptureDevices
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListCaptureDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        public event Action SettingOk;

        public int DeviceIndex { get => deviceList.SelectedIndex; set => deviceList.SelectedIndex = value; }
        public int ModeIndex { get => modesList.SelectedIndex; set => modesList.SelectedIndex = value; }
        public string[] DeviceList { set => deviceList.Items.AddRange(value); }
        public string[] ModesList { set => modesList.Items.AddRange(value); }

        private void BtnOkSettingDev_Click(object sender, EventArgs e)
        {
            SettingOk();
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
