using AForge.Video.DirectShow;
using System.Collections.Generic;

namespace WebCamCapture.Model
{
    public class Devices
    {
        FilterInfoCollection videoDevices;
        /// <summary>
        /// Количество подключенных устройств
        /// </summary>
        public int CounterDevices { get => videoDevices.Count; }
        /// <summary>
        /// Возвращает коллекцию устройств
        /// </summary>
        public FilterInfoCollection DevicesCollection { get => videoDevices; }     
               
        /// <summary>
        /// Взращает список имен подключенных устройств
        /// </summary>
        /// <returns></returns>
        public List<string> GetDeviceNameList()
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