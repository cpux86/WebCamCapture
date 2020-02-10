using AForge.Video.DirectShow;
using System.Collections.Generic;
using WebCamCapture.Model;

namespace WebCamCapture.Model
{
    class Devices
    {
        
        FilterInfoCollection videoDevices;
        Device device;

        public Devices()
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
        }
        /// <summary>
        /// Количество подключенных устройств
        /// </summary>
        public int Counter { get => videoDevices.Count; }

        /// <summary>
        /// Выбрать устройство 
        /// </summary>
        /// <param name="_deviceId"></param>
        /// <returns></returns>
        public Device SelectedDevice(int _deviceId )
        {           
            if (device != null) return device;
            device = Device.getInstance();
            Device.Moniker = videoDevices[_deviceId].MonikerString;
            Device.Dev();
            return device;
        }
        /// <summary>
        /// Взращает список имен подключенных устройств
        /// </summary>
        /// <returns></returns>
        public List<string> GetDevicesNameList()
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            // заполняем список именами подклюен
            
            List<string> _list = new List<string>();
            foreach (FilterInfo device in videoDevices)
            {
                _list.Add(device.Name);
            }
            return _list;
        }
    }
}