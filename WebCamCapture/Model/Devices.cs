using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AForge.Video.DirectShow;

using System.Drawing;

namespace WebCamCapture.Model
{
    interface IDevice
    {
        VideoCaptureDevice VideoSource { get; }
        List<string> GetFrameSizeList(int devId);
        void Run();
    }
    interface IDevices : IDevice
    {
        List<string> GetDevicesNameList();
    }

    public class Devices : IDevices
    {
        private VideoCaptureDevice videoSource;

        #region Список имен и режимов
        private FilterInfoCollection videoDevices;

        public VideoCaptureDevice VideoSource => videoSource;

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
            if (devId == -1) return fSize;
            videoSource = new VideoCaptureDevice(videoDevices[devId].MonikerString);
            // поддерживаемые режимы работы камеры (разрешение)
            foreach (var s in VideoSource.VideoCapabilities)
            {
                // формируем строку типа 640 x 480
                fSize.Add(String.Format("{0} x {1}, {2} fps, {3} Bit", s.FrameSize.Width, s.FrameSize.Height, s.MaximumFrameRate, s.BitCount));
            }
            return fSize;
        }
        #endregion

        Snapshot fileManager;
        // запускаем устройство на выполниние 
        public void Run()
        {
            videoSource.NewFrame += VideoSource_NewFrame;
            fileManager = new Snapshot();
        }
        // обработчик получения кадра с устройства
        private void VideoSource_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            fileManager.NewFrame(eventArgs.Frame);
        }
    }

}
