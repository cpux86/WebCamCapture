using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accord.Video.DirectShow;

using System.Drawing;

namespace WebCamCapture.Model
{
    class Devices
    {
        public FilterInfoCollection videoDevices;

        public VideoCaptureDevice videoSource;

        /// <summary>
        /// Взращает список имен подключенных устройств
        /// </summary>
        /// <returns></returns>
        public List<string> GetDevicesNameList()
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            // заполняем список именами подклюен
            List<string> list = new List<string>();
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
            if (devId > videoDevices.Count || devId < 0)
                // поддерживаемые режимы работы камеры (разрешение)
                foreach (var s in videoSource.VideoCapabilities)
                {
                    videoSource = new VideoCaptureDevice(videoDevices[devId].MonikerString);
                    // формируем строку типа 640 x 480
                    fSize.Add(String.Format("{0} x {1}, {2} fps, {3} Bit", s.FrameSize.Width, s.FrameSize.Height, s.MaximumFrameRate, s.BitCount));

                }
            return fSize;
        }
    }
}
