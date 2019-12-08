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
        private ArrayList videoModes;
        private String selectedDeviceName;
        private int selectedDeviceIndex = 0;
        private int selectedVideoMode;
        public bool screen = false;
        Form forms;

        public WebCamCapture()
        {
            // выбранное устройство из пользовтельских конфикураций
           // selectedDeviceName = Properties.Settings.Default.SelectedDeviceName;
        }

        /// <summary>
        /// Список имен подключенных устройств
        /// </summary>
        public List<string> ListNameDevices { get => listNameDevices; }
        

        /// <summary>
        /// Массив поддерживаемых режимов (разрешение видео) выбранного устройства.
        /// </summary>
        public ArrayList VideoModes { get => videoModes; }

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
        /// 1. Получить список всех подключенных устройств. 1.1. Сохранить список в listNameDevices.
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
            camView = cv;
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            selectedDeviceName = Properties.Settings.Default.SelectedDeviceName;

            if (videoDevices.Count > 0)
            {
                // 1.



                UpdateDevicesNameList();

                if (ListNameDevices.IndexOf(selectedDeviceName) != -1)
                    selectedDeviceIndex = ListNameDevices.IndexOf(selectedDeviceName);


                ArrayList mod = new ArrayList();
                videoSource = new VideoCaptureDevice(videoDevices[this.SelectedDeviceIndex].MonikerString);

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
        /// Обновляет список подключенных устройств
        /// </summary>
        internal bool UpdateDevicesNameList()
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice); ;
            List<string>  list = new List<string>();
            foreach (FilterInfo device in videoDevices)
            {

                //listNameDevices.Add(device.Name);
                list.Add(device.Name);

            }
            if (this.ListNameDevices == null)
            {
                listNameDevices = list;
            }



            //if (listNameDevices.IndexOf(selectedDeviceName) != -1)
            //    selectedDeviceIndex = listNameDevices.IndexOf(selectedDeviceName);



            if (!list.SequenceEqual<string>(listNameDevices))
            {
                listNameDevices = list;
                return true;
            }
            return false;
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
                var image = camView.Image;

                if (image != null)
                {
                    image.Dispose();
                    camView.Image = null;

                }
                camView.Image = (Bitmap)eventArgs.Frame.Clone();
                if (screen)
                {
                    //ScreenView
                }
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
