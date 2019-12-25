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
            capture.UpdateListNameDevices();
            if (capture.DevicesCounter > 0)
            {
                ListCaptureDevices.Items.AddRange(capture.ListNameDevices.ToArray());
                ListCaptureDevices.SelectedIndex = capture.SelectedDeviceIndex;
            }

            ListCaptutreModes.Items.Clear();
            capture.UpdateListVideoModes(ListCaptureDevices.SelectedIndex);
            ListCaptutreModes.Items.AddRange(capture.ListVideoModes.ToArray());
        }
        /// <summary>
        /// выбор разрешения захвата видео из выподающего списка ListCaptutreModes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListCaptutreModes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // возможно не нужен
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

        private int dev;
        private int mod;

        public int Dev { get => dev; set => dev = value; }
        public int Mod { get => mod; set => mod = value; }

        /// <summary>
        /// Применить настройки захвата и начать захват видео
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnOkSettingDev_Click(object sender, EventArgs e)
        {
            // проверить доступность выбранного устройства и режима захвата
            // 
            //capture.ValidDevice(dev, mode);
            dev = capture.GetIndexByName(capture.ListNameDevices, ListCaptureDevices.SelectedItem.ToString());
            mod = capture.GetIndexByName(capture.ListVideoModes, ListCaptutreModes.SelectedItem.ToString());

        }

        private void SettingAppPanel__BtnOk_Click(object sender, EventArgs e)
        {
            
        }
    }
}
