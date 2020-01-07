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
    public class Pleer : IPleer
    {

        FilterInfoCollection videoDevices;
        VideoCaptureDevice videoSource;
        List<string> deviceList;
        List<string> listVideoModes;
        int deviceId = 0;
        int modeId;
        bool isDeviceReady;
        private Image _frame;

        public event Action<Image> NewFrame;

        public Pleer()
        {
            init();
        }

        /// <summary>
        /// Список  устройств
        /// </summary>
        public Array DeviceList { get => deviceList.ToArray(); }
        /// <summary>
        /// Список поддерживаемых режимов (разрешение видео) выбранного устройства.
        /// </summary>
        public Array ListVideoModes { get => listVideoModes.ToArray(); }
        /// <summary>
        /// Идентификатор выбранного устройстова. 
        /// </summary>
        public int DeviceId { get => deviceId; set => deviceId = value; }
        /// <summary>
        /// Идентификатор выбранного видеорежима (выбранное разрешение)
        /// </summary>
        public int ModeId { get => modeId; set => modeId = value; }
        /// <summary>
        /// Устройство готово?
        /// </summary>
        public bool IsDeviceReady { get; }


        /// <summary>
        /// Имя выбранного устройства
        /// </summary>
        string DeviceName { get => Properties.Settings.Default.SelectedDeviceName; set => Properties.Settings.Default.SelectedDeviceName = value; }
        /// <summary>
        /// Выбранный размер кадра
        /// </summary>
        string FrameSize { get => Properties.Settings.Default.SelectedFrameSize; set => Properties.Settings.Default.SelectedFrameSize = value; }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool init()
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (this.UpdateListNameDevices())
            {
                this.UpdateListNameDevices();
                this.UpdateListVideoModes(DeviceId);
                this.Start(DeviceName, FrameSize);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Начинает захват видео 
        /// </summary>
        /// <param name="deviceName">Имя устройстова</param>
        /// <param name="FrameSize">Размер кадра</param>
        public void Start(string DeviceName, string FrameSize)
        {
            int dev = GetIndexByName(deviceList, DeviceName);
            int mod = GetIndexByName(listVideoModes, FrameSize);
            DeviceId = dev;
            ModeId = mod;
            videoSource = new VideoCaptureDevice(videoDevices[dev].MonikerString);
            videoSource.VideoResolution = videoSource.VideoCapabilities[mod];
            videoSource.NewFrame += new NewFrameEventHandler(video_NewFrame);
            videoSource.Start();
        }

        /// <summary>
        /// обновляет список доступных разрешений, список доступен через свойство ListVideoModes
        /// </summary>
        /// <param name="deviceId">id выбранного устройства</param>
        /// <returns></returns>
        public bool UpdateListVideoModes(int deviceId)
        {
            List<string> fSize = new List<string>();
            videoSource = new VideoCaptureDevice(videoDevices[deviceId].MonikerString);
            if (videoSource.VideoCapabilities.Length == 0) return false;  // если в устройстве не передостовляет список доступных разрешений!
            // поддерживаемые режимы работы камеры (разрешение)
            foreach (var s in videoSource.VideoCapabilities)
            {
                // формируем строку типа 640 x 480
                fSize.Add(String.Format("{0} x {1}", s.FrameSize.Width, s.FrameSize.Height));
               
            }

            this.listVideoModes = fSize; // инициализируем или обновляем список доступных разрешений 
            return true;
        }

        /// <summary>
        /// Обновляет список подключенных устройств и счетчик DevicesCounter.Обновленный список устройств доступен через свойство ListNameDevices.
        /// </summary>
        /// <returns>Возращает TRUE если список был изменен</returns>
        public bool UpdateListNameDevices()
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            // заполняем список именами подклюен
            List<string> list = new List<string>();
            foreach (FilterInfo device in videoDevices)
            {
                list.Add(device.Name);
            }

            deviceList = list;

            this.isDeviceReady = videoDevices.Count > 0 ? true : false;
            return isDeviceReady;
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
            videoSource.NewFrame -= new NewFrameEventHandler(video_NewFrame);
            if (videoSource != null)
            {

                videoSource.SignalToStop();
                videoSource.WaitForStop();
                videoSource.Stop();
            }

        }
    }
}
