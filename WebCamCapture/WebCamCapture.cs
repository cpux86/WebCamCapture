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

        //private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        private PictureBox сamView;
        private ArrayList devices;
        private ArrayList videoModes;
        private String selectedDeviceName;
        private int selectedDevice;
        private int selectedVideoMode;
        Form forms;

        public WebCamCapture()
        {
            // выбранное устройство из пользовтельских конфикураций
            selectedDeviceName = Properties.Settings.Default.SelectedDeviceName;
        }

        /// <summary>
        /// Массив имен подключенных устройств
        /// </summary>
        public ArrayList Devices { get => devices; }

        /// <summary>
        /// Массив поддерживаемых режимов (разрешение видео) выбранного устройства.
        /// </summary>
        public ArrayList VideoModes { get => videoModes; }

        /// <summary>
        /// Выбранное устройстово.
        /// </summary>
        public int SelectedDevice { get => selectedDevice; set => selectedDevice = value; }
        /// <summary>
        /// Выбранный видеорежим (выбранное разрешение)
        /// </summary>
        public int SelectedVideoMode { get => selectedVideoMode; set => selectedVideoMode = value; }

        /// <summary>
        /// init();
        /// 1. Получить список всех подключенных устройств. 1.1. Сохранить список в devices.
        ///    1.2. Если устройства не обнаружены, то через N секунд повторно опрашиваем систему. 
        /// 2. Установить устройство по умолчанию, получить его имя (Config int GetSelectedDevice), из настроек приложения (SelectedDeviceName). 
        ///    Если устройство из настроек не подключено, то устойство по умолчанию будет первое в списке устройств (selectedDevice = 0).
        /// 3. Получить список всех поддерживаемых режимов захвата (разрешение), сохранить его в - VideoModes. 
        ///    Если в настройках приложения имеются сведения о выбранном режиме, то 
        ///    сохраняем идентефикатор пользовательского режима (разрешения) в свойстве SelectedVideoMode. Если в настройках выбанный  режим не установлен,
        ///    то устанавливаем режим по умолчанию SelectedVideoMode = 0.
        /// </summary>
        /// <param name="cv"></param>
        /// <param name="f"></param>
        /// <returns></returns>
        public bool init(PictureBox cv, Form f)
        {
            forms = f;
            сamView = cv;
            FilterInfoCollection videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            // GetDivicesList();
            
            
            if (videoDevices.Count > 0)
            {
                // 1.
                ArrayList mod = new ArrayList();
                devices = new ArrayList();
                foreach (FilterInfo device in videoDevices)
                {
                    
                    devices.Add(device.Name);
                    
                }

                // 2. 
                devices.IndexOf(selectedDeviceName);


                videoSource = new VideoCaptureDevice(videoDevices[this.SelectedDevice].MonikerString);

                // поддерживаемые режимы работы камеры (разрешение)
                foreach (var s in videoSource.VideoCapabilities)
                {
                    mod.Add(s.FrameSize.Width + "x" + s.FrameSize.Height);
                }

                videoSource.NewFrame += new NewFrameEventHandler(video_NewFrame);
                videoSource.Start();
                                
                this.videoModes = mod;
                return true;
            }
            else
            {
                //MessageBox.Show("Камера не подключена!");
                return false;
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool Start()
        {
            return true;
        }

        public void GetCamList()
        {

        }
        public void Error(object sender, VideoSourceErrorEventArgs eventArgs)
        {
            MessageBox.Show("Ошибка");
        }

        /// <summary>
        /// Обработчик события поступления кадра
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs"></param>
        private void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {

            forms.Invoke((MethodInvoker)(() =>
            {
                var image = сamView.Image;

                if (image != null)
                {
                    image.Dispose();
                    сamView.Image = null;

                }
                сamView.Image = (Bitmap)eventArgs.Frame.Clone();
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
            if (this.SelectedVideoMode != mode)
            {
                this.SelectedVideoMode = mode;
                this.Stop();
                videoSource.VideoResolution = videoSource.VideoCapabilities[this.SelectedVideoMode];
                videoSource.Start();
            }



        }
    }
}
