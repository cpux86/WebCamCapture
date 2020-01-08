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
        }
        
        private void SettingDevice_Load(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// выбор устройства из выподающего списка ListCaptureDevices
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListCaptureDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private string dev;
        private string mod;

        public event Action SettingOk;

        public string Dev { get => dev; set => dev = value; }
        public string Mod { get => mod; set => mod = value; }



        private void BtnOkSettingDev_Click(object sender, EventArgs e)
        {
            SettingOk();
            this.Close();
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
