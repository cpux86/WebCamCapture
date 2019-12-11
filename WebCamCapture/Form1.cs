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
using System.Threading;

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
        private ImageBrowser imgBrowser;
        private void Form1_Load(object sender, EventArgs e)
        {

            wcc = new WebCamCapture();
            // инициализация, проверка наличия подключенных камер.
            if (wcc.init(CamView,this))
            {
                ListCaptureDevices.Items.AddRange(wcc.ListNameDevices.ToArray());
               // wcc.SelectedDeviceIndex = 0; // индекс устройстова по умолчанию
               // ListCaptureDevices.SelectedIndex = wcc.SelectedDeviceIndex;

                ListCaptutreModes.Items.AddRange(wcc.VideoModes.ToArray());
                //wcc.SelectedVideoMode = 0; // видеорежим по умолчанию.
                ListCaptutreModes.SelectedIndex = wcc.SelectedVideoMode;

                btnScreenCapture.Enabled = true;
                wcc.UpdateListNameDevices();
                ListCaptureDevices.SelectedIndex = wcc.SelectedDeviceIndex;
            }
            //
            
        }

        private void BtnScreenCapture_Click(object sender, EventArgs e)
        {         
            string path;
            path = DateTime.Now.ToString().Replace(":", "-");
            path += DateTime.Now.Ticks + ".jpg";
            //CamView.Image.Save(path, System.Drawing.Imaging.ImageFormat.Jpeg);
            //ScreenView.Image = (Bitmap)CamView.Image.Clone();
            if (ScreenView.Image != null)
            {
                ScreenView.Image.Dispose();
            }
             
            ScreenView.Image = (Bitmap)CamView.Image.Clone();
            // wcc.PathSaveFile = path;


            CamView.Image.Save(path, System.Drawing.Imaging.ImageFormat.Jpeg);


            // ScreenView.ImageLocation = path;

            //Invoke((MethodInvoker)(() =>
            //{
            //    ScreenView.Image = CamView.Image;
            //    ScreenView.ImageLocation = path;
            //}));

        }


        ///
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
            wcc.SelectedDeviceIndex = ListCaptureDevices.SelectedIndex;
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
            //Thread.Sleep(8000);
            // wcc.Stop();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

        }
        // Обновляет список устройств
        private void ListCaptureDevices_MouseDown(object sender, MouseEventArgs e)
        {
            wcc.UpdateListNameDevices();
            ListCaptureDevices.Items.Clear();
            ListCaptureDevices.Items.AddRange(wcc.ListNameDevices.ToArray());
            ListCaptureDevices.SelectedIndex = wcc.SelectedDeviceIndex;

        }

        private void ListCaptureDevices_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void ScreenView_DoubleClick(object sender, EventArgs e)
        {
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
            CamView.Width = SystemInformation.PrimaryMonitorSize.Width;
            CamView.Height = SystemInformation.PrimaryMonitorSize.Height;
        }

        private void CamView_DoubleClick(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            CamView.Width = SystemInformation.PrimaryMonitorSize.Width;
            CamView.Height = SystemInformation.PrimaryMonitorSize.Height;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void Button1_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Test");
        }
    }

    
}
