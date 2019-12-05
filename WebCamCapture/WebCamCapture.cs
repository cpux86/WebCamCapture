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
        private PictureBox сamView;
        private ArrayList devices;
        private ArrayList videoModes;
        private int selectedDevice;
        private int selectedVideoMode;
        Form forms;

        /// <summary>
        /// Массив подключенных устройств
        /// </summary>
        public ArrayList Devices { get => devices; }

        /// <summary>
        /// Массив поддерживаемых режимов (разрешение видео).
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
        /// 1. Получить список всех подключенных устройств. Если устройства не обнаружены, то через N секунд повторно опрашиваем систему. 
        /// 2. Установить устройство по умолчанию, получить его имя из настроек приложения. 
        ///    Если устройство из настроек не подключено, то устойство по умолчанию будет первое в списке устройств.
        /// 3. Получить список всех поддерживаемых режимов развата (разрешение). Если в настройках приложения имеются сведения о выбранном режиме, то 
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
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (videoDevices.Count > 0)
            {
                ArrayList mod = new ArrayList();
                devices = new ArrayList();

                foreach (FilterInfo device in videoDevices)
                {
                    
                    devices.Add(device.Name);
                }

                //
                videoSource = new VideoCaptureDevice(videoDevices[this.SelectedDevice].MonikerString);
                videoSource.NewFrame += new NewFrameEventHandler(video_NewFrame);
                videoSource.Start();
                

                // ошибки камеры
                videoSource.VideoSourceError += new VideoSourceErrorEventHandler(Error);




                // поддерживаемые режимы работы камеры (разрешение)
                foreach (var s in videoSource.VideoCapabilities)
                {
                    mod.Add(s.FrameSize.Width + "x" + s.FrameSize.Height);
                }
                this.videoModes = mod;
                return true;
            }
            else
            {
                //MessageBox.Show("Камера не подключена!");
                return false;
            }

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
