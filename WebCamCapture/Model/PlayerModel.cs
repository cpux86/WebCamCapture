using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Threading;

namespace WebCamCapture.Model
{
    /// <summary>
    /// Робота с web камерой, сознаие и сохнанение снимков
    /// </summary>
    public class PlayerModel : IPlayer
    {

        FilterInfoCollection videoDevices;
        VideoCaptureDevice videoSource;
        List<string> _deviceList;
        List<string> _listModes;
        int _deviceIndex = 0;
        int _modeId;
        private bool _isReady = false;
        private Image _frame;

        public event Action<Image> NewFrame;
        public event Action<int> ChangeDeviceId;
        public event Action ChangeModId;

        /// <summary>
        /// Список  устройств
        /// </summary>
        public List<string> DeviceList { get => _deviceList; }
        /// <summary>
        /// Список поддерживаемых режимов (разрешение видео) выбранного устройства.
        /// </summary>
        public List<string> ListVideoModes { get => _listModes; }
        /// <summary>
        /// Идентификатор выбранного устройстова. 
        /// </summary>
        public int DeviceIndex { get => _deviceIndex; set => _deviceIndex = value; }
        /// <summary>
        /// Идентификатор выбранного видеорежима (выбранное разрешение)
        /// </summary>
        public int ModeIndex { get => _modeId; set => _modeId = value; }
        /// <summary>
        /// Устройство готово?
        /// </summary>
        //public bool IsReady { get => _isReady; set => _isReady = value; }


        /// <summary>
        /// Имя выбранного устройства
        /// </summary>
        public string DeviceName { get => Properties.Settings.Default.SelectedDeviceName; set => Properties.Settings.Default.SelectedDeviceName = value; }
        /// <summary>
        /// Выбранный размер кадра
        /// </summary>
        public string FrameSize { get => Properties.Settings.Default.SelectedFrameSize; set => Properties.Settings.Default.SelectedFrameSize = value; }

        /// <summary>
        /// Состояние захвата видео 
        /// </summary>
        public bool IsRunning { get => this.videoSource != null ? this.videoSource.IsRunning : false; }

        /// <summary>
        /// Получает список имен подключенных устройств
        /// </summary>
        /// <returns>Возращает TRUE если список был изменен</returns>
        public List<string> GetDeviceNameList()
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            // заполняем список именами подклюен
            List<string> list = new List<string>();
            foreach (FilterInfo device in videoDevices)
            {
                list.Add(device.Name);
            }

            _deviceList = list;
            return _deviceList;
        }

        //CameraControlFlags controlFlags;
        //int _z;
        /// <summary>
        /// Начинает захват видео 
        /// </summary>
        /// <param name="device">Идентификатор устройстова</param>
        /// <param name="mode">Размер кадра</param>
        public void Start()
        {
            try
            {
                videoSource.Stop();
                videoSource.VideoResolution = videoSource.VideoCapabilities[ModeIndex];
                //videoSource.SetCameraProperty(CameraControlProperty.Zoom, 100, CameraControlFlags.Manual); //
                //videoSource.SetCameraProperty(CameraControlProperty.)
                //videoSource.GetCameraProperty(CameraControlProperty.Zoom, out _z, out controlFlags);
                videoSource.NewFrame += new NewFrameEventHandler(video_NewFrame);
                videoSource.Start();
            }
            catch (Exception)
            {

                MessageBox.Show("Error");
            }
        }

        /// <summary>
        ///  Возращает список поддерживаемых рижимов 
        /// </summary>
        /// <param name="deviceId">id выбранного устройства</param>
        /// <returns></returns>
        public List<string> GetListVideoModes(int deviceId)
        {
            List<string> fSize = new List<string>();
            videoSource = new VideoCaptureDevice(videoDevices[deviceId].MonikerString);
            //if (videoSource.VideoCapabilities.Length == 0) return false;  // если в устройстве не передостовляет список доступных разрешений!
            // поддерживаемые режимы работы камеры (разрешение)
            foreach (var s in videoSource.VideoCapabilities)
            {
                // формируем строку типа 640 x 480
                fSize.Add(String.Format("{0} x {1}", s.FrameSize.Width, s.FrameSize.Height));

            }
            return fSize;
        }


        /// <summary>
        /// получаем индекс выбранного элемента по его имени, если элемент не обнаружен то возращаем 0.
        /// </summary>
        /// <param name="list">список где искать</param>
        /// <param name="name">что искать в списке</param>
        /// <returns></returns>
        public int GetIndexByName(List<string> list, string name)
        {
            return list.IndexOf(name) != -1 ? list.IndexOf(name) : 0;
        }

        // сохранение конфигураций
        public void SaveConfig()
        {
            Properties.Settings.Default.Save();
        }


        /// <summary>
        /// Обработчик события поступления кадра.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs"></param>
        private void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            NewFrame(eventArgs.Frame);
        }

        /// <summary>
        /// Завершение работы программы захвата
        /// </summary>
        public void Stop()
        {
            if (this.IsRunning)
            {
                videoSource.NewFrame -= new NewFrameEventHandler(video_NewFrame);
                videoSource.SignalToStop();
                videoSource.WaitForStop();
            }

        }
        // вызывается при завершении программы
        public void Shutdown()
        {
            this.Stop();
            this.SaveConfig();
        }

        public void SetZoom(int x)
        {
            videoSource.SetCameraProperty(CameraControlProperty.Zoom, x, CameraControlFlags.Manual);
        }
        public void SetFocus(int f)
        {
            videoSource.SetCameraProperty(CameraControlProperty.Focus, f, CameraControlFlags.Manual);
        }

        #region Настройки камеры

        public void GetZoom( out int _zoom, out CameraControlFlags _flags)
        {
            videoSource.GetCameraProperty(CameraControlProperty.Zoom, out _zoom, out _flags);
        }




        #endregion
    }
}
