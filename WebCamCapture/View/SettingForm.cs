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
        public int ScaleValue { 
            get => trackScale.Value; 
            set { 
                trackScale.Value = value;
                numScale.Value = value;
            } 
        }
        public int FocusValue
        {
            get => trackFocus.Value;
            set
            {
                trackFocus.Value = value;
                numFocus.Value = value;
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
        /// <summary>
        /// Клик по кнопке OK на форме настроек
        /// </summary>
        public event Action BtnOkClick;
        // события "Масштаб"
        public event Action ScaleChange;
        // событие "Фокус"
        public event Action FocusChange;

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
        // обработчик ползунка "Маштаб"
        private void TrackScale_Scroll(object sender, EventArgs e)
        {
            int _trackScale = trackScale.Value;
            if (_trackScale != this.ScaleValue)
            {
                this.ScaleValue = _trackScale;

                numScale.Value = _trackScale;
                ScaleChange();
            }


            numScale.Value = trackScale.Value;
            this.ScaleValue = trackScale.Value;
            ScaleChange();
        }
        // обработчик изменеия цифравого заначения "Масштаб"
        private void NumScale_ValueChanged(object sender, EventArgs e)
        {
            int _numScale = (int)numScale.Value;
            if (_numScale != this.ScaleValue)
            {
                //MessageBox.Show("Test");
                // 
                this.ScaleValue = (int)numScale.Value;
                // выравниваем значение ползунка Масштаб и его цифравое значение
                trackScale.Value = _numScale;
                ScaleChange();
            }
            
        }
        // обработчик Масштаб режим Auto
        private void ChScaleAuto_CheckedChanged(object sender, EventArgs e)
        {
            if (chScaleAuto.Checked)
            {
                // запрещаем скроллить и вводить занчения
                numScale.Enabled = false;
                trackScale.Enabled = false;
            }
            else
            {
                numScale.Enabled = true;
                trackScale.Enabled = true;
            }

        }
        // обработчик ползунка "Фокус"
        private void trackFocus_Scroll(object sender, EventArgs e)
        {
            int _trackFocus = (int)numFocus.Value;
            if (_trackFocus != this.FocusValue)
            {
                //MessageBox.Show("Test");
                // 
                this.FocusValue = (int)numFocus.Value;
                // выравниваем значение ползунка Масштаб и его цифравое значение
                trackFocus.Value = _trackFocus;
                FocusChange();
            }
        }
    }
}
