using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Controls;

namespace WebCamCapture
{
    public partial class Form1 : Form
    {

        

        public Form1()
        {
            InitializeComponent();
           
        }

        private WebCamCapture wcc;
        private ImageBrowser imgBrowser;
        private void Form1_Load(object sender, EventArgs e)
        {

            wcc = new WebCamCapture();
            // инициализация, проверка наличия подключенных камер.
            if (wcc.init(CamView,this))
            {
                ListCaptureDevices.Items.AddRange(wcc.Devices.ToArray());
                wcc.SelectedDevice = 0; // индекс устройстова по умолчанию
                ListCaptureDevices.SelectedIndex = wcc.SelectedDevice; 
                

                ListCaptutreModes.Items.AddRange(wcc.VideoModes.ToArray());
                wcc.SelectedVideoMode = 0; // видеорежим по умолчанию.
                ListCaptutreModes.SelectedIndex = wcc.SelectedVideoMode;

                btnScreenCapture.Enabled = true;
            }
        }

        private void BtnScreenCapture_Click(object sender, EventArgs e)
        {
            string path;
            path = DateTime.Now.ToString().Replace(":", "-") + ".jpg";
            CamView.Image.Save(path, System.Drawing.Imaging.ImageFormat.Jpeg);
            

            Invoke((MethodInvoker)(() =>
            {
                ScreenView.Image = CamView.Image;
                ScreenView.ImageLocation = path; 
            }));

            
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
            // получить список подключенных устройств
            // 
            // GetCamList();
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

        /// <summary>
        /// test
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click(object sender, EventArgs e)
        {


            
        }
    }

    
}
