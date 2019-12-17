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

        /// <summary>
        /// включены ли элементы упрвления устройством
        /// </summary>
        public bool EnableDeviceControl { get => btnScreenCapture.Enabled; set {
                btnScreenCapture.Enabled = ListCaptutreModes.Enabled = value; 
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            wcc = new WebCamCapture();
            // инициализация, проверка наличия подключенных камер.
            if (wcc.init(CamView,this))
            {
                ListCaptureDevices.Items.AddRange(wcc.ListNameDevices.ToArray());
               // wcc.SelectedDeviceIndex = 0; // индекс устройстова по умолчанию
               // ListCaptureDevices.SelectedIndex = wcc.SelectedDeviceIndex;

                ListCaptutreModes.Items.AddRange(wcc.ListVideoModes.ToArray());
                //wcc.SelectedVideoMode = 0; // видеорежим по умолчанию.
                ListCaptutreModes.SelectedIndex = wcc.SelectedVideoMode;

                btnScreenCapture.Enabled = true;
                wcc.UpdateListNameDevices();
                ListCaptureDevices.SelectedIndex = wcc.SelectedDeviceIndex;
            }
            wcc.UpdateListNameDevices();

        }

        private void BtnScreenCapture_Click(object sender, EventArgs e)
        {         
            string NameFile;
            NameFile = DateTime.Now.ToString().Replace(":", "-");
            NameFile += DateTime.Now.Ticks + ".jpg";
            if (ScreenView.Image != null)
            {
                ScreenView.Image.Dispose();
            }          
            ScreenView.Image = (Bitmap)CamView.Image.Clone();
            CamView.Image.Save(NameFile, System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        ///
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            wcc.SaveConfig();
            wcc.Stop();
            
        }


        // Обновляет список устройств
        private void ListCaptureDevices_MouseDown(object sender, MouseEventArgs e)
        {

                

            //ListCaptureDevices.Items.Clear();
            //ListCaptureDevices.Items.AddRange(wcc.ListNameDevices.ToArray());
            //ListCaptureDevices.Items.AddRange(wcc.ListNameDevices.ToArray());
            //ListCaptureDevices.SelectedIndex = wcc.SelectedDeviceIndex;

        }
        /// <summary>
        /// Обработчик выбора разрешения (режима) захвата из списка  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListCaptureDevices_SelectionChangeCommitted(object sender, EventArgs e)
        {
            wcc.ChangeModeCapture(ListCaptutreModes.SelectedIndex);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //this.EnableDeviceControl = !this.EnableDeviceControl;
            MessageBox.Show(wcc.UpdateListNameDevices().ToString());
        }

    }

    
}
