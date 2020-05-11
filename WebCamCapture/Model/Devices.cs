﻿using Accord.Video.DirectShow;
using System;
using System.Collections.Generic;

namespace WebCamCapture.Model
{
    interface IDevice
    {
        VideoCaptureDevice VideoSource { get; }
        List<string> GetFrameSizeList(int devId);
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

        public Devices()
        {
            // заглушка, создает пустой источник. Благодаря этому возможно кликать на кнопу "Создать снимок" не выбрав источник 
            videoSource = new VideoCaptureDevice();
        }

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

    }

}
