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
    public partial class SettingForm : Form, ISettingView
    {
        public SettingForm()
        {
            InitializeComponent();
        }

        public int DeviceIndex { get => deviceList.SelectedIndex; set => deviceList.SelectedIndex = value; }
        public int ModeIndex { get => modesList.SelectedIndex; set => modesList.SelectedIndex = value; }
        /// <summary>
        ///  выбранно устройство в настройках
        /// </summary>
        public event Action DeviceIdChange;
        /// <summary>
        ///  выбран режим в настройках
        /// </summary>
        public event Action ModeIdChange;
        /// <summary>
        /// Клик по кнопке OK на форме настроек
        /// </summary>
        public event Action BtnOkClick;
        public string[] DeviceList { 
            set {
                deviceList.Items.Clear();
                deviceList.Items.AddRange(value);
            }       
        }
        public string[] ModesList { 
            set {
                modesList.Items.Clear();
                modesList.Items.AddRange(value);
            } 
        }
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

        private void deviceList_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DeviceIdChange();
        }

        private void modesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ModeIdChange();
        }
        //обработчик клика по кнопке ОК в форме настроек
        private void BtnOkSettingDev_Click(object sender, EventArgs e)
        {
            BtnOkClick();
        }
    }
}
