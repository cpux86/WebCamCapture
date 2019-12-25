﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace WebCamCapture
{
    /// <summary>
    /// Робота с web камерой, сознаие и сохнанение снимков
    /// </summary>
    public class Capture : MainForm
    {

        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        private PictureBox camView;
        private List<string> listNameDevices;
        private List<string> listVideoModes;
        private string selectedDeviceName;
        private int selectedDeviceIndex = 0;
        private int selectedVideoMode;
        private string selectedFrameSize;
        Form forms;

        public Capture()
        {
            // Имя выбранного устройства из пользовтельских конфигураций, на момент завершения программы.
            selectedDeviceName = Properties.Settings.Default.SelectedDeviceName;
            // Текстовое предстовление размера кадра, в конфигурациях пользователя
            selectedFrameSize = Properties.Settings.Default.SelectedFrameSize;
        }

        /// <summary>
        /// Список имен подключенных устройств
        /// </summary>
        public List<string> ListNameDevices { get => listNameDevices; }
        /// <summary>
        /// Список поддерживаемых режимов (разрешение видео) выбранного устройства.
        /// </summary>
        public List<string> ListVideoModes { get => listVideoModes; }
        /// <summary>
        /// Index выбранного устройстова. 
        /// </summary>
        public int SelectedDeviceIndex { get => selectedDeviceIndex; set => selectedDeviceIndex = value; }
        /// <summary>
        /// Выбранный видеорежим (выбранное разрешение)
        /// </summary>
        public int SelectedVideoMode { get => selectedVideoMode; set => selectedVideoMode = value; }
        /// <summary>
        /// счетчик подключенных устройств.
        /// </summary>
        public int DevicesCounter { get; private set; }



        /// <summary>
        /// init();
        /// <param name="cv"></param>
        /// <param name="f"></param>
        /// <returns></returns>
        public bool init(PictureBox cv, Form f)
        {
            forms = f;
            camView = cv;
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (videoDevices.Count > 0)
            {
                this.UpdateListNameDevices();

                // подключено ли выбранное устройство, имя которого получено из конфигураций, если да, selectedDeviceIndex будет хранить его системный индекс.
                if (ListNameDevices.IndexOf(selectedDeviceName) != -1)
                    selectedDeviceIndex = ListNameDevices.IndexOf(selectedDeviceName);

                List<string> fSize = new List<string>();
                videoSource = new VideoCaptureDevice(videoDevices[this.SelectedDeviceIndex].MonikerString);
                // поддерживаемые режимы работы камеры (разрешение)
                foreach (var s in videoSource.VideoCapabilities)
                {
                    // формируем строку типа 640 x 480
                    fSize.Add(String.Format("{0} x {1}", s.FrameSize.Width, s.FrameSize.Height));
                }
                
               
                                
                this.listVideoModes = fSize;


                // поддерживает ли выбранное устройство размер када (разрешение), полученое из конфигураций пользователя.
                if (ListVideoModes.IndexOf(selectedFrameSize) != -1)
                {
                    // устанавливаем текущий видеорежим равет режиму из настроек
                    selectedVideoMode = ListVideoModes.IndexOf(selectedFrameSize);
                }

                videoSource.NewFrame += new NewFrameEventHandler(video_NewFrame);
                //
                videoSource.VideoResolution = videoSource.VideoCapabilities[this.SelectedVideoMode];   



                videoSource.Start();
                return true;
            }
            else
            {
                //MessageBox.Show("Камера не подключена!");
                return false;
            }

        }
        /// <summary>
        /// Начинает захват видео 
        /// </summary>
        /// <param name="dev">устройстово</param>
        /// <param name="mod">разрешение</param>
        internal void Start(int dev, int mod)
        {
            this.Stop();
            videoSource.VideoResolution = videoSource.VideoCapabilities[mod];
            //videoSource.NewFrame += new NewFrameEventHandler(video_NewFrame);
            videoSource.Start();
        }

        /// <summary>
        /// обновляет список доступных разрешений, список доступен через свойство ListVideoModes
        /// </summary>
        /// <param name="deviceId">id выбранного устройства</param>
        /// <returns></returns>
        public bool UpdateListVideoModes(int deviceId) {
            List<string> fSize = new List<string>();
            videoSource = new VideoCaptureDevice(videoDevices[deviceId].MonikerString);
            if (videoSource.VideoCapabilities.Length == 0) return false;  // если в устройстве не передостовляет список доступных разрешений!
            // поддерживаемые режимы работы камеры (разрешение)
            foreach (var s in videoSource.VideoCapabilities)
            {
                // формируем строку типа 640 x 480
                fSize.Add(String.Format("{0} x {1}", s.FrameSize.Width, s.FrameSize.Height));
            }
            
            this.listVideoModes = fSize; // инициализируем или обновляем список доступных разрешений 
            return true;
        }

        /// <summary>
        /// Обновляет список подключенных устройств и счетчик DevicesCounter.Обновленный список устройств доступен через свойство ListNameDevices.
        /// </summary>
        /// <returns>Возращает TRUE если список был изменен</returns>
        public bool UpdateListNameDevices()
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            this.DevicesCounter = videoDevices.Count;
            // заполняем список именами подклюен
            List<string>  list = new List<string>();
            foreach (FilterInfo device in videoDevices)
            {
                list.Add(device.Name);
            }
            // Первый старт. Инициализация listNameDevices списком подключенных устройств. Происходит при старте программы
            // с подключенным устройстовом, либо устройстово было подключено во время работы программы. Или старый список равен новому 
            if (this.ListNameDevices == null)
            {
                listNameDevices = list;
                return true;
            }
            // Обновление списка. Новый список не равен предидущему.Устройство было отключено или подключено, обновляем список listNameDevices
            if (!list.SequenceEqual<string>(listNameDevices))
            {
                listNameDevices = list;
               
                return true;
            }
            return false;
        }
        /// <summary>
        /// получаем индекс выбранного элемента по его имени, если элемент не обнаружен то возращаем 0.
        /// </summary>
        /// <param name="list">список где искать</param>
        /// <param name="name">что искать в списке</param>
        /// <returns></returns>
        public int GetIndexByName(List<string> list, string name) {
            return list.IndexOf(name) != -1 ? list.IndexOf(name) : 0;
        }

        // сохранение конфигураций
        public void SaveConfig()
        {
            // Получаем имя устройства по его индексу
            this.selectedDeviceName = this.listNameDevices[selectedDeviceIndex]; // так не годится!!!
            this.selectedFrameSize = this.ListVideoModes[SelectedVideoMode];

            Properties.Settings.Default.SelectedFrameSize = this.selectedFrameSize;

            Properties.Settings.Default.SelectedDeviceName = this.selectedDeviceName;
            Properties.Settings.Default.Save();
        }


        /// <summary>
        /// Обработчик события поступления кадра.
        /// Из поступивших кадров в CamView формеруется видео. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs"></param>
        private void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {   
            forms.Invoke((MethodInvoker)(() =>
            {
                Image image = camView.Image;
                if (image != null)
                {
                    image.Dispose();
                    camView.Image = null;

                }
                camView.Image = (Bitmap)eventArgs.Frame.Clone();
                camView.Image.RotateFlip(RotateFlipType.Rotate180FlipY);
            }));
        }

        /// <summary>
        /// Завершение работы программы захвата
        /// </summary>
        public void Stop()
        {
            forms.Invoke((MethodInvoker)(() =>
            {
                if (videoSource != null)
                {
                    videoSource.SignalToStop();
                    videoSource.WaitForStop();
                }
            }));
        }

        /// <summary>
        /// Смена разрешения захвата
        /// </summary>
        public void ChangeModeCapture(int mode)
        {
          
            try
            {
                if (this.SelectedVideoMode != mode)
                {
                    this.SelectedVideoMode = mode;
                    this.Stop();
                    videoSource.VideoResolution = videoSource.VideoCapabilities[this.SelectedVideoMode];
                    videoSource.Start();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
    }
}
