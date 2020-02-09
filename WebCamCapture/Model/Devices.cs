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
        /// Возвращает коллекцию устройств
        /// </summary>

        // Instance
        public Device GetDevice(int _deviceId )
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