using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCamCapture.View;
using WebCamCapture.Model;
using System.Drawing;
using System.Windows.Forms;
//using Accord.Video.DirectShow;
using AForge.Video.DirectShow;
using System.Windows.Forms.VisualStyles;

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

        /// <summary>
        /// путь к снимкам из настроек
        /// </summary>
        string SnapshotDir
        {
            get => Properties.Settings.Default.FileDir;
            set => Properties.Settings.Default.FileDir = value;
        }

        #endregion


        readonly IPlayerMainView PlayerMainView;
        readonly ISettingView settingView;
        private VideoCaptureDevice VideoSource { get => devices.VideoSource; }
        readonly IDevices devices;
        readonly IDevice device;

        public SettingPresenter(IPlayerMainView playerMainView, ISettingView settingView, IDevices devices)
        {
            this.devices = devices;
            this.device = devices;


            this.PlayerMainView = playerMainView;
            this.settingView = settingView;

            this.PlayerMainView.Load += PlayerMainView_Load;
            this.PlayerMainView.ShowAppSetting += PlayerMainView_ShowAppSetting;
            this.PlayerMainView.ShowDeviceManagerPanel += PlayerMainView_ShowDeviceManagerPanel;
            this.PlayerMainView.MakeSnapshot += PlayerMainView_makeSnapshot;
            
            settingView.DeviceIdChange += SettingView_DeviceIdChange;
            settingView.ModeIdChange += SettingForm_ModeIdChange;
            settingView.SnapshotDirChange += SettingView_SnapshotDirChange;

            this.Init();
            
        }
        // Обработчик выбора каталога сохранения снимков
        private void SettingView_SnapshotDirChange(string path)
        {
            this.SnapshotDir = path;
        }

        // Выбор устройства
        private void SettingView_DeviceIdChange()
        {
            this.DeviceId = settingView.DeviceIndex;
            this.ModesList = device.GetFrameSizeList(this.DeviceId);
            settingView.ModesList = ModesList.ToArray();
        }

        // Выбор видеорежим
        private void SettingForm_ModeIdChange()
        {
            this.ModeId = this.settingView.ModeIndex;
            this.Run();

        }
        // Первоначатьная инициализация
        private void Init()
        {

            // получаем список подключенных устройств
            this.DevicesNameList = devices.GetDevicesNameList();

            // получаем идентификатор устройства из настроек
            this.DeviceId = DevicesNameList.IndexOf(this.SelectedDevice);
            // получаем список поддерживаемых режимов устройством
            this.ModesList = devices.GetFrameSizeList(this.DeviceId);
            // получаем идентификатор режима из настроек
            this.ModeId = ModesList.IndexOf(this.SelectedMode);
            // получаем путь к снимкам
            this.settingView.SnapshotFolder = this.SnapshotDir;

            this.settingView.DeviceList = this.DevicesNameList.ToArray();
            this.settingView.ModesList = this.ModesList.ToArray();

            this.settingView.DeviceIndex = this.DeviceId;
            this.settingView.ModeIndex = this.ModeId;

        }

        #region Обработчики
        // Главная форма загружена
        private void PlayerMainView_Load(object sender, EventArgs e)
        {

            if (PlayerMainView.IsRunning)
            {
                PlayerMainView.DeviceManagerItem = true;
            }
            else
            {
                PlayerMainView.DeviceManagerItem = false;
            }

        }

        // Форма основных настроек загружена (устройства, режима и путь к снимкам) программы 
        private void PlayerMainView_ShowAppSetting()
        {

            // Щелчек по кнопке "Ок" формы "Настройки камеры"
            if (settingView.ShowDialog() == DialogResult.OK && ModesList.Count > 0 && this.ModeId != -1)
            {
                this.SelectedDevice = this.DevicesNameList[this.DeviceId];
                this.SelectedMode = this.ModesList[this.ModeId];
            }
        }



        // Отобразить панель с настройкаи (фокус, экспозиция, выдержка...) камеры 
        private void PlayerMainView_ShowDeviceManagerPanel()
        {
            try
            {
                VideoSource.DisplayPropertyPage(IntPtr.Zero);
            }
            catch (NotSupportedException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }         
        }

        void Run() {
            if (DeviceId != -1 && ModeId != -1)
            {             
                if (PlayerMainView.IsRunning) PlayerMainView.Stop();
                VideoSource.VideoResolution = VideoSource.VideoCapabilities[ModeId];
                PlayerMainView.VideoSource = VideoSource;
                device.Run();

                VideoSource.NewFrame += VideoSource_NewFrame;

                PlayerMainView.Start();
                PlayerMainView.DeviceManagerItem = true;
                
            }
        }






        // Создать снимок
        private void PlayerMainView_makeSnapshot()
        {
            VideoSource.NewFrame -= SaveSnapshot;
            VideoSource.NewFrame += SaveSnapshot;
            

        }

        private void SaveSnapshot(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            PlayerMainView.SnapshotView((Bitmap)eventArgs.Frame.Clone());
            WebCamCapture.Model.FileManager fileManager = new Model.FileManager();

            var name = fileManager.CreateFileName();
            Image image = (Bitmap)eventArgs.Frame.Clone();
            image.Save(name, System.Drawing.Imaging.ImageFormat.Jpeg);
            image.Dispose();

        }

        private void VideoSource_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            VideoSource.NewFrame -= SaveSnapshot;
        }

        #endregion

    }
}
