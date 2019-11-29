using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace WebCamCapture
{
    public partial class Form1 : Form
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // инициализация, проверка наличия подключенных камер.
            //init();

            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (videoDevices.Count > 0)
            {
                foreach (FilterInfo device in videoDevices)
                {
                    CamList.Items.Add(device.Name);
                }
                CamList.SelectedIndex = 0;
            }
        }

        private void BtnVideoCapture_Click(object sender, EventArgs e)
        {
            videoSource = new VideoCaptureDevice(videoDevices[CamList.SelectedIndex].MonikerString);
            videoSource.NewFrame += new NewFrameEventHandler(video_NewFrame);
            VideoCapabilities[] capabilities = videoSource.VideoCapabilities;

            foreach (var item in videoSource.VideoCapabilities)
            {
                comboBox1.Items.Add(item.FrameSize.Width + "x" + item.FrameSize.Height);
            }
            //videoSource.VideoResolution = capabilities[17]; // устанавливаем разрешение 1280x720
            videoSource.Start();
            
        }

        private void BtnScreenCapture_Click(object sender, EventArgs e)
        {
            CamView.Image.Save(DateTime.Now.ToString().Replace(":", "-")+".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        private void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Invoke((MethodInvoker)(() =>
                {
                    var image = CamView.Image;

                    if (image != null)
                    {
                        CamView.Image = null;
                        image.Dispose();
                    }
                    CamView.Image = (Bitmap)eventArgs.Frame.Clone();
                }));


        }

 
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Invoke((MethodInvoker)(() =>
            {
                if (videoSource != null)
                {
                    videoSource.SignalToStop();
                    videoSource.WaitForStop();
                }
            }));
        }

        private void BtnSetting_Click(object sender, EventArgs e)
        {
            
            foreach (var item in videoSource.VideoCapabilities)
            {
                comboBox1.Items.Add(item.FrameSize.Width+"x"+ item.FrameSize.Width);
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Invoke((MethodInvoker)(() =>
            {
                if (videoSource != null)
                {
                    videoSource.SignalToStop();
                    videoSource.WaitForStop();
                }
            }));

            VideoCapabilities[] capabilities = videoSource.VideoCapabilities;
            videoSource.VideoResolution = capabilities[comboBox1.SelectedIndex];           
            videoSource.Start();

        }

        private void CamList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

    public class WebCamCapture {
        public void init()
        {

        }
    }
}
