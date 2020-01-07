using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WebCamCapture.Model
{
    interface IPleer
    {
        //List<string> ListNameDevices { get; }
        //List<string> ListVideoModes { get; }
        //void Start(string DeviceName, string FrameSize);
        void Stop();

        /// <summary>
        /// Список доступных устройств
        /// </summary>
        Array DeviceList { get; }
        /// <summary>
        /// Список поддерживаемых режимов (разрешение видео) выбранного устройства.
        /// </summary>
        Array ListVideoModes { get; }
        /// <summary>
        /// Идентификатор выбранного устройстова. 
        /// </summary>
        int DeviceId { get; set; }
        /// <summary>
        /// Идентификатор выбранного видеорежима (выбранное разрешение)
        /// </summary>
        int ModeId { get; set; }
        /// <summary>
        /// Имя выбранного устройства
        /// </summary>
        //string SelectedDeviceName { get; set; }
        /// <summary>
        /// Выбранный размер кадра
        /// </summary>
        //string SelectedFrameSize { get; set; }




        /// <summary>
        /// Новый кадр
        /// </summary>
        event Action<Image> NewFrame;


    }
}
