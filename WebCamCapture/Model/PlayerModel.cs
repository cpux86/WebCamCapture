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
        bool isDeviceReady;
        private Image _frame;

        public event Action<Image> NewFrame;
        public event Action<int> ChangeDeviceId;
        public event Action ChangeModId;

        public PlayerModel()
        {
            init();
            
        }

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
        //public bool IsDeviceReady { get; }


        /// <summary>
        /// Имя выбранного устройства
        /// </summary>
        string DeviceName { get => Properties.Settings.Default.SelectedDeviceName; set => Properties.Settings.Default.SelectedDeviceName = value; }
        /// <summary>
        /// Выбранный размер кадра
        /// </summary>
        string FrameSize { get => Properties.Settings.Default.SelectedFrameSize; set => Properties.Settings.Default.SelectedFrameSize = value; }

        /// <summary>
        /// Состояние захвата видео 
        /// </summary>
        public bool IsRunning { get => this.videoSource != null ? this.videoSource.IsRunning : false; }



        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool init()
        {
            //videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            //if (this.GetDeviceNameList())
            //{
            //    this.GetDeviceNameList();
            //    this.UpdateListVideoModes(DeviceIndex);
            //    //this.Start(DeviceName, FrameSize);
            //    return true;
            //}
            return false;
        }

        /// <summary>
        /// Начинает захват видео 
        /// </summary>
        /// <param name="deviceName">Имя устройстова</param>
        /// <param name="FrameSize">Размер кадра</param>
        public void Start(string DeviceName, string FrameSize)
        {

            this.Stop();

            int dev = GetIndexByName(_deviceList, DeviceName);
            int mod = GetIndexByName(_listModes, FrameSize);
            DeviceIndex = dev;
            ModeIndex = mod;
            videoSource = new VideoCaptureDevice(videoDevices[dev].MonikerString);
            videoSource.VideoResolution = videoSource.VideoCapabilities[mod];
            videoSource.NewFrame += new NewFrameEventHandler(video_NewFrame);
            //videoSource.Start();
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

            this._listModes = fSize; // инициализируем или обновляем список доступных разрешений 
            return _listModes;
        }

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

            //this.isDeviceReady = videoDevices.Count > 0 ? true : false;
            return _deviceList;
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
            //return 1;
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

            if (_frame != null)
            {
                _frame.Dispose();
                _frame = null;

            }
            eventArgs.Frame.RotateFlip(RotateFlipType.Rotate180FlipY);
            _frame = (Bitmap)eventArgs.Frame.Clone();
            NewFrame(_frame);
           
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
                //videoSource.Stop();
            }

        }
    }
}
