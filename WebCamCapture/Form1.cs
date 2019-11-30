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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        private WebCamCapture wcc;
        private void Form1_Load(object sender, EventArgs e)
        {

            wcc = new WebCamCapture();
            // инициализация, проверка наличия подключенных камер.
            if (wcc.init(CamView,this))
            {
                ListCaptureDevices.Items.AddRange(wcc.Devices.ToArray());
                wcc.SelectedDevice = 0; // устройстово по умолчанию
                ListCaptureDevices.SelectedIndex = wcc.SelectedDevice;
                

                ListCaptutreModes.Items.AddRange(wcc.VideoModes.ToArray());
                wcc.SelectedVideoMode = 0; // видеорежим по умолчанию.
                ListCaptutreModes.SelectedIndex = wcc.SelectedVideoMode;

                btnScreenCapture.Enabled = true;
            }

        }

        private void BtnScreenCapture_Click(object sender, EventArgs e)
        {
            CamView.Image.Save(DateTime.Now.ToString().Replace(":", "-")+".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            wcc.Stop();
        }


        /// <summary>
        /// Выбор устройства 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListCapureDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            wcc.SelectedDevice = ListCaptureDevices.SelectedIndex;
        }

        /// <summary>
        /// Выбор режима захвата
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListCaputreModes_SelectedIndexChanged(object sender, EventArgs e)
        {
            wcc.ChangeModeCapture(ListCaptutreModes.SelectedIndex);     
        }

    }

    public class WebCamCapture {

        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        private PictureBox CamView;
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

        public bool init(PictureBox cv, Form f)
        {
            forms = f;
            CamView = cv;
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
            else {
                //MessageBox.Show("Камера не подключена!");
                return false;
            }

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
                    var image = CamView.Image;

                    if (image != null)
                    {
                        image.Dispose();
                        CamView.Image = null;

                    }
                    CamView.Image = (Bitmap)eventArgs.Frame.Clone();
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
