
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
using System.Resources;

using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace WebCamCapture.View
{
    interface IMain
    {
        bool DeviceManagerItem { set; }
        event EventHandler Load;
        event FormClosingEventHandler FormClosing;
        /// <summary>
        /// Создать снимок
        /// </summary>
        event Action MakeSnapshot;
        event Action ShowAppSetting;
        event Action ShowDeviceManagerPanel;

    }
    interface IPlayerMainView : IMain
    {
        IVideoSource VideoSource { set; }
        void Start();
        void Stop();
        bool IsRunning { get; }
        //void SnapshotView();
        void SnapshotView(Image image);

    }
    interface IOrderMainForm : IMain
    {
        string OrderNumber { set; }
        string Roller { set; }
        string Operation { set; }
        string User { set; }
        /// <summary>
        /// Отображение формы заказа
        /// </summary>
        event Action ShowOrderForm;
    }
    internal partial class MainForm : Form, IMain, IPlayerMainView, IOrderMainForm
    {
        public MainForm()
        {
            InitializeComponent();
            this.KeyPreview = true;
            
        }



        #region Сведения о заказе
        public string OrderNumber { set => TextOrderMainForm.Text = value; }
        public string Roller { set => TextRollerMainForm.Text = value; }
        public string Operation { set => TextOprerationMainForm.Text = value; }
        public string User { set => OperatorFullNameMainForm.Text = value; }



        #endregion


        public IVideoSource VideoSource { set => videoPlayer.VideoSource = value; }
        public bool DeviceManagerItem { set => deviceManagerItem.Enabled = value; }

        public event Action MakeSnapshot;
        public event Action ShowAppSetting;
        public event Action ShowDeviceManagerPanel;
        public event Action ShowOrderForm;

        private void makeSnapshotBtn_Click(object sender, EventArgs e)
        {
            MakeSnapshot();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        public bool IsRunning { get => videoPlayer.IsRunning; }
        public void Start()
        {
            videoPlayer.Start();
        }

        public void Stop()
        {
            Invoke((MethodInvoker)(() => {
                if (videoPlayer.VideoSource != null)
                {
                    videoPlayer.SignalToStop();
                    videoPlayer.WaitForStop();
                    videoPlayer.Stop();
                    videoPlayer.VideoSource = null;
                }
            }));
          
        }

        private void ShowAppSetting_Click(object sender, EventArgs e)
        {
            ShowAppSetting();
        }

        private void ShowDeviceManagerPanel_Click(object sender, EventArgs e)
        {
            ShowDeviceManagerPanel();
        }

        public void SnapshotView(Image img)
        {
            Invoke((MethodInvoker)(() => {
                if (snapshotView.Image != null)
                {
                    snapshotView.Image.Dispose();
                }
                snapshotView.Image = img;
            }));
        }
        // Отобразить форму заказа
        private void OrderEditBtn_Click(object sender, EventArgs e)
        {
            ShowOrderForm();
        }
    }

   
}