using System;
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
    public class WebCamCapture
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

        public WebCamCapture()
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
        /// Массив поддерживаемых режимов (разрешение видео) выбранного устройства.
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
        /// init();
        /// <param name="cv"></param>
        /// <param name="f"></param>
        /// <returns></returns>
        public bool init(PictureBox cv, Form f)
        {
            forms = f;
            camView = cv;
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            // эта строка есть в конструкторе
            //selectedDeviceName = Properties.Settings.Default.SelectedDeviceName;

            if (videoDevices.Count > 0)
            {
                this.UpdateListNameDevices();

                // подключено ли выбранное устройство, имя которого получено из конфигураций, если да, selectedDeviceIndex будет хранить его системный индекс.
                if (ListNameDevices.IndexOf(selectedDeviceName) != -1)
                    selectedDeviceIndex = ListNameDevices.IndexOf(selectedDeviceName);

                //// Получаем имя устройства по его индексу
                //this.selectedDeviceName = this.listNameDevices[selectedDeviceIndex];

                List<string> fSize = new List<string>();
                videoSource = new VideoCaptureDevice(videoDevices[this.SelectedDeviceIndex].MonikerString);

                // поддерживаемые режимы работы камеры (разрешение)
                foreach (var s in videoSource.VideoCapabilities)
                {
                    // формируем строку типа 640 x 480
                    fSize.Add(String.Format("{0} x {1}", s.FrameSize.Width, s.FrameSize.Height));
                }
                videoSource.NewFrame += new NewFrameEventHandler(video_NewFrame);
                videoSource.Start();
                                
                this.listVideoModes = fSize;


                // поддерживает ли выбранное устройство размер када (разрешение), полученое из конфигураций пользователя.
                if (ListVideoModes.IndexOf(selectedFrameSize) != -1)
                {
                    // устанавливаем текущий видеорежим равет режиму из настроек
                    selectedVideoMode = ListVideoModes.IndexOf(selectedFrameSize);
                }

                return true;
            }
            else
            {
                //MessageBox.Show("Камера не подключена!");
                return false;
            }

        }

        /// <summary>
        /// Обновить список подключенных устройств. Список подключенных устройство доступен через свойство List<string> ListNameDevices. 
        /// </summary>
        /// <returns></returns>
        internal bool UpdateListNameDevices()
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice); ;
            List<string>  list = new List<string>();
            foreach (FilterInfo device in videoDevices)
            {
                list.Add(device.Name);
            }
            if (this.ListNameDevices == null)
            {
                listNameDevices = list;
            }

            if (!list.SequenceEqual<string>(listNameDevices))
            {
                listNameDevices = list;
                return true;
            }
            return false;
        }
            

        public void GetCamList()
        {

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
