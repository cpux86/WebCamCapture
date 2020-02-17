using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCamCapture.View;
using WebCamCapture.Model;
using System.Drawing;
using System.Windows.Forms;

namespace WebCamCapture.Presenter
{
    class SettingPresenter
    {
        #region Свойства
        /// <summary>
        /// Список устройств
        /// </summary>
        List<string> DevicesNameList { get; set; }
        /// <summary>
        /// Список режимов
        /// </summary>
        List<string> ModesList { get; set; }
        /// <summary>
        /// Идентификатор устройства
        /// </summary>
        int DeviceId { get; set; }

        int ModeId { get; set; }
        /// <summary>
        /// Устройство из настроек
        /// </summary>
        string SelectedDevice
        {
            get => Properties.Settings.Default.SelectedDeviceName;
            set => Properties.Settings.Default.SelectedDeviceName = value;
        }
        /// <summary>
        /// Режим захвата из настроек
        /// </summary>
        string SelectedMode
        {
            get => Properties.Settings.Default.SelectedMode;
            set => Properties.Settings.Default.SelectedMode = value;
        }

        #endregion

        readonly IPlayerMainView PlayerMainView;
        readonly ISettingView settingView;
        Device device;
        public SettingPresenter(IPlayerMainView playerMainView, ISettingView settingView)
        {
            this.PlayerMainView = playerMainView;
            this.settingView = settingView;

            this.PlayerMainView.Load += PlayerMainView_Load;
            this.PlayerMainView.ShowAppSetting += PlayerMainView_ShowAppSetting;
            this.PlayerMainView.ShowDeviceManagerPanel += PlayerMainView_ShowDeviceManagerPanel;
            this.PlayerMainView.MakeSnapshot += PlayerMainView_makeSnapshot;

        }





        #region Обработчики
        Devices devices;
        // Главная форма загружена
        private void PlayerMainView_Load(object sender, EventArgs e)
        {
            devices = new Devices();
            this.DevicesNameList = devices.GetDevicesNameList();
            this.settingView.DeviceList = this.DevicesNameList.ToArray();
            device = devices.SelectedDevice(1);
            var modList = device.GetFrameSizeList();
            //device.videoSource.VideoResolution = device.videoSource.VideoCapabilities[2];
            PlayerMainView.VideoSource = device.videoSource;
            //PlayerMainView.Start();
        }

        // Отобразить форму основных настроек (устройства, режима и путь к снимкам) программы 
        private void PlayerMainView_ShowAppSetting()
        {
            settingView.DeviceIdChange += SettingView_DeviceIdChange;
            settingView.ModeIdChange += SettingForm_ModeIdChange;
            if (settingView.ShowDialog() == DialogResult.OK)
            {
                
            }
        }
        // Выбор устройства
        private void SettingView_DeviceIdChange()
        {
            this.DeviceId = this.settingView.DeviceIndex;
            device = devices.SelectedDevice(DeviceId);
            this.ModesList = device.GetFrameSizeList();
            this.settingView.ModesList = this.ModesList.ToArray();
            //throw new NotImplementedException();
        }

        // Выбор видеорежим
        private void SettingForm_ModeIdChange()
        {
            this.ModeId = this.settingView.ModeIndex;
            this.Run();
            //throw new NotImplementedException();
        }

        // Отобразить панель с настройкаи (фокус, экспозиция, выдержка...) камеры 
        private void PlayerMainView_ShowDeviceManagerPanel()
        {
            try
            {
                device.videoSource.DisplayPropertyPage(IntPtr.Zero);
            }
            catch (NotSupportedException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }         
        }

        void Run() {
            if (DeviceId != -1 && ModeId != -1)
            {             
                if (PlayerMainView.IsRunnig) PlayerMainView.Stop();
                device.videoSource.VideoResolution = device.videoSource.VideoCapabilities[ModeId];
                PlayerMainView.VideoSource = device.videoSource;
                PlayerMainView.Start();
            }
        }


        // Создать снимок
        private void PlayerMainView_makeSnapshot(Image image)
        {

        }
        #endregion

    }
}
