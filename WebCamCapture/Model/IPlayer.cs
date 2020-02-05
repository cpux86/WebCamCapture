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
        void Stop();

        string DeviceName { get; set; }
        string FrameSize { get; set; }
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
        /// Состояние захвата видео 
        /// </summary>
        bool IsRunning { get; }
        //bool IsReady { get; set; }

        void Start();

        List<string> GetDeviceNameList();
        List<string> GetListVideoModes(int deviceId);




        /// <summary>
        /// Новый кадр
        /// </summary>
        event Action<Image> NewFrame;
        event Action<int> ChangeDeviceId;
        event Action ChangeModId;

        void Shutdown();
    }
}
