using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCamCapture.Model
{
    class Device : Devices
    {
        VideoCaptureDevice videoSource;
        /// <summary>
        /// Возращает список поддерживаемых размеров кадров
        /// </summary>
        /// <param name="dev">Идентификатор устройства</param>
        /// <returns></returns>
        public List<string> GetFrameSizeList(int dev)
        {
            List<string> fSize = new List<string>();
            videoSource = new VideoCaptureDevice(DevicesCollection[dev].MonikerString);
            // инициализируем свойства устройства
            this.PropertyRange();
            // поддерживаемые режимы работы камеры (разрешение)
            foreach (var s in videoSource.VideoCapabilities)
            {
                // формируем строку типа 640 x 480
                fSize.Add(String.Format("{0} x {1}", s.FrameSize.Width, s.FrameSize.Height));

            }
            return fSize;
        }



        void PropertyRange()
        {
            //
            int _minValue;
            int _maxValue;
            int _stapSize;
            int _defValuse;
            CameraControlFlags _controlFlags;

            videoSource.GetCameraPropertyRange(
                CameraControlProperty.Exposure,
                out _minValue,
                out _maxValue,
                out _stapSize,
                out _defValuse,
                out _controlFlags);
        }
    }
}
