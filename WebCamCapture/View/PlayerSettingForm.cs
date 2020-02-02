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
    public partial class PlayerSettingForm : Form, ISettingView
    {
        public PlayerSettingForm()
        {
            InitializeComponent();
        }

        public int DeviceIndex { get => deviceList.SelectedIndex; set => deviceList.SelectedIndex = value; }
        public int ModeIndex { get => modesList.SelectedIndex; set => modesList.SelectedIndex = value; }
        public string[] DeviceList { set => deviceList.Items.AddRange(value); }
        public string[] ModesList { set => modesList.Items.AddRange(value); }
        public string SnapshotFolder
        {
            get => folderBrowserDialog1.SelectedPath;
            set
            {
                folderBrowserDialog1.SelectedPath = value;
                SettinAppPanel__FileDirView.Text = value;
            }
        }
        public string SnapshotFolderTextBox { set => SettinAppPanel__FileDirView.Text = value; }


        private void SettingAppPanel__DirOkBtn_Click(object sender, EventArgs e)
        {         
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                SettinAppPanel__FileDirView.Text = folderBrowserDialog1.SelectedPath;
                Properties.Settings.Default.FileDir = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}
