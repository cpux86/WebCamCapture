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



        #region Список имен и режимов
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        /// <summary>
        /// Взращает список имен подключенных устройств
        /// </summary>
        /// <returns></returns>
        public List<string> GetDevicesNameList()
        {
            // заполняем список именами подклюен
            List<string> list = new List<string>();
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in videoDevices)
            {
                list.Add(device.Name);
            }
            return list;
        }

        /// <summary>
        /// Возращает список поддерживаемых размеров кадров
        /// </summary>
        /// <param name="dev">Идентификатор устройства</param>
        /// <returns></returns>
        public List<string> GetFrameSizeList(int devId)
        {
            List<string> fSize = new List<string>();
            videoSource = new VideoCaptureDevice(videoDevices[devId].MonikerString);
            // поддерживаемые режимы работы камеры (разрешение)
            foreach (var s in videoSource.VideoCapabilities)
            {             
                // формируем строку типа 640 x 480
                fSize.Add(String.Format("{0} x {1}, {2} fps, {3} Bit", s.FrameSize.Width, s.FrameSize.Height, s.MaximumFrameRate, s.BitCount));
            }
            return fSize;
        }
        #endregion





        readonly IPlayerMainView PlayerMainView;
        readonly ISettingView settingView;

        public SettingPresenter(IPlayerMainView playerMainView, ISettingView settingView)
        {
            videoSource = new VideoCaptureDevice(); // защита
            this.PlayerMainView = playerMainView;
            this.settingView = settingView;

            this.PlayerMainView.Load += PlayerMainView_Load;
            this.PlayerMainView.ShowAppSetting += PlayerMainView_ShowAppSetting;
            this.PlayerMainView.ShowDeviceManagerPanel += PlayerMainView_ShowDeviceManagerPanel;
            this.PlayerMainView.MakeSnapshot += PlayerMainView_makeSnapshot;
            
            settingView.DeviceIdChange += SettingView_DeviceIdChange;
            settingView.ModeIdChange += SettingForm_ModeIdChange;
            
            
        }

        // Выбор устройства
        private void SettingView_DeviceIdChange()
        {
            this.DeviceId = settingView.DeviceIndex;
            settingView.ModesList = GetFrameSizeList(this.DeviceId).ToArray();
        }

        // Выбор видеорежим
        private void SettingForm_ModeIdChange()
        {
            this.ModeId = this.settingView.ModeIndex;
            this.Run();

        }


        #region Обработчики
        // Главная форма загружена
        private void PlayerMainView_Load(object sender, EventArgs e)
        {
            this.DevicesNameList = GetDevicesNameList();
            this.settingView.DeviceList = this.DevicesNameList.ToArray();
            if (PlayerMainView.IsRunning)
            {
                PlayerMainView.DeviceManagerItem = true;
            }
            else
            {
                PlayerMainView.DeviceManagerItem = false;
            }
            // тест
            var dev = this.DevicesNameList;
            this.DeviceId = dev.IndexOf(this.SelectedDevice);
            this.ModeId = dev.IndexOf(this.SelectedMode);


           // Run(); /////////////////

        }

        // Отобразить форму основных настроек (устройства, режима и путь к снимкам) программы 
        private void PlayerMainView_ShowAppSetting()
        {
            //
            this.DeviceId = 1;
            this.ModeId = 1;

            this.settingView.DeviceIndex = this.DeviceId;
            this.settingView.ModeIndex = this.ModeId;
            // Щелчек по кнопке "Ок" формы "Настройки камеры"
            if (settingView.ShowDialog() == DialogResult.OK)
            {
                
            }
        }



        // Отобразить панель с настройкаи (фокус, экспозиция, выдержка...) камеры 
        private void PlayerMainView_ShowDeviceManagerPanel()
        {
            try
            {
                videoSource.DisplayPropertyPage(IntPtr.Zero);
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
                videoSource.VideoResolution = videoSource.VideoCapabilities[ModeId];
                PlayerMainView.VideoSource = videoSource;
                videoSource.NewFrame += VideoSource_NewFrame;
                PlayerMainView.Start();
                PlayerMainView.DeviceManagerItem = true;
                
            }
        }

        // Создать снимок
        private void PlayerMainView_makeSnapshot()
        {
            videoSource.NewFrame -= SaveSnapshot;
            videoSource.NewFrame += SaveSnapshot;
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
            videoSource.NewFrame -= SaveSnapshot;
        }

        #endregion

    }
}
