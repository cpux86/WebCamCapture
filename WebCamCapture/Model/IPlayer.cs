using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WebCamCapture.Model
{
    interface IPlayer
    {
        //List<string> ListNameDevices { get; }
        //List<string> ListVideoModes { get; }
        //void Start(string DeviceName, string FrameSize);
        void Stop();

        /// <summary>
        /// Список доступных устройств
        /// </summary>
        List<string> DeviceList { get; }
        /// <summary>
        /// Список поддерживаемых режимов (разрешение видео) выбранного устройства.
        /// </summary>
        List<string> ListVideoModes { get; }
        /// <summary>
        /// Идентификатор выбранного устройстова. 
        /// </summary>
        int DeviceIndex { get; set; }
        /// <summary>
        /// Идентификатор выбранного видеорежима (выбранное разрешение)
        /// </summary>
        int ModeIndex { get; set; }
        /// <summary>
        /// Имя выбранного устройства
        /// </summary>
        //string SelectedDeviceName { get; set; }
        /// <summary>
        /// Выбранный размер кадра
        /// </summary>
        //string SelectedFrameSize { get; set; }

        /// <summary>
        /// Состояние захвата видео 
        /// </summary>
        bool IsRunning { get; }
        void Start(string DeviceName, string NameMode);





        /// <summary>
        /// Новый кадр
        /// </summary>
        event Action<Image> NewFrame;
        event Action<int> ChangeDeviceId;
        event Action ChangeModId;
        
    }
}
