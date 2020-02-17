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
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
        }

        public int DeviceIndex { get => deviceList.SelectedIndex; set => deviceList.SelectedIndex = value; }
        public int ModeIndex { get => modesList.SelectedIndex; set => modesList.SelectedIndex = value; }
        public int ZoomValue { 
            get => trackZoom.Value; 
            set { 
                trackZoom.Value = value;
                numZoom.Value = value;
            } 
        }
        //
        public int FocusValue
        {
            get => trackFocus.Value;
            set
            {
                trackFocus.Value = value;
                numFocus.Value = value;
            }
        }
        //
        public int ExposureValue
        {
            get => trackExposure.Value;
            set
            {
                trackExposure.Value = value;
                numExposure.Value = value;
            }
        }

        /// <summary>
        ///  выбранно устройство в настройках
        /// </summary>
        public event Action DeviceIdChange;
        /// <summary>
        ///  выбран режим в настройках
        /// </summary>
        public event Action ModeIdChange;
        // события "Масштаб"
        public event Action ZoomChange;
        // событие "Фокус"
        public event Action FocusChange;
        // событие "Экспозиции"
        public event Action ExposureChange;

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

        // обработчик ползунка "Маштаб"
        private void TrackZoom_Scroll(object sender, EventArgs e)
        {
            if ((int)numZoom.Value != trackZoom.Value)
            {
                // синхронизируем значение
                this.ZoomValue = trackZoom.Value;
                // уведомляем об изменении Zoom
                ZoomChange();
            }
        }
        // обработчик изменеия цифравого заначения "Масштаб"
        private void NumScale_ValueChanged(object sender, EventArgs e)
        {
            if (trackZoom.Value != (int) numZoom.Value)
            {
                // синхронизируем значение
                this.ZoomValue = (int)numZoom.Value;
                // уведомляем об изменении Zoom
                ZoomChange();
            }
        }
        // обработчик Масштаб режим Auto
        private void ChScaleAuto_CheckedChanged(object sender, EventArgs e)
        {
            if (chScaleAuto.Checked)
            {
                // запрещаем скроллить и вводить занчения
                numZoom.Enabled = false;
                trackZoom.Enabled = false;
            }
            else
            {
                numZoom.Enabled = true;
                trackZoom.Enabled = true;
            }

        }
        #region Настройки фокуса

        // обработчик ползунка "Фокус"
        private void trackFocus_Scroll(object sender, EventArgs e)
        {
            //int _trackFocus = trackFocus.Value;
            //int _numFocus = (int)numFocus.Value;
            // новое значение фокуса отличается
            if (trackFocus.Value != (int)numFocus.Value)
            {
                // синхронизируем значение
                this.FocusValue = trackFocus.Value;
                // уведмляем о изменении Фокус
                FocusChange();
            }
        }

        // обработчик ввода числа
        private void NumFocus_ValueChanged(object sender, EventArgs e)
        {
            if ((int)numFocus.Value != trackFocus.Value)
            {
                // синхронизируем значение
                this.FocusValue = (int)numFocus.Value;
                // уведмляем о изменении Фокус
                FocusChange();
            }
        }
        // обработчик флага FocusAuto
        private void ChFocusAuto_CheckedChanged(object sender, EventArgs e)
        {
            if (chFocusAuto.Checked)
            {
                // запрещаем скроллить и вводить занчения
                numFocus.Enabled = false;
                trackFocus.Enabled = false;
            }
            else
            {
                numFocus.Enabled = true;
                trackFocus.Enabled = true;
            }
        }



        #endregion

        private void TrackExposure_Scroll(object sender, EventArgs e)
        {
            if ((int)numExposure.Value != trackExposure.Value)
            {
                // синхронизируем значение
                this.ExposureValue = trackExposure.Value;
                // уведомляем об изменении Zoom
                FocusChange();
            }
        }
    }
}
