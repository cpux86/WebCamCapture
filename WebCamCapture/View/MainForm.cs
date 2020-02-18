
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
//using AForge.Video;
using Accord.Video.DirectShow;
using Accord.Video;

namespace WebCamCapture.View
{
    interface IMain
    {
        bool DeviceManagerItem { set; }
        event EventHandler Load;
        event FormClosingEventHandler FormClosing;
        /// <summary>
        /// События создания снимка
        /// </summary>
        event Action MakeSnapshot;
        event Action ShowAppSetting;
        event Action ShowDeviceManagerPanel;
    }

    internal interface IPlayerMainView : IMain
    {
        IVideoSource VideoSource { set; }
        void Start();
        void Stop();
        bool IsRunning { get; }

    }

    internal partial class MainForm : Form, IMain, IPlayerMainView
    {
        public MainForm()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }



        #region Сведения о заказе
        public string OrderNumber { set => OrderPanel__TextOrder.Text = value; }
        public string Roller { set => OrderPanel__TextRoller.Text = value; }
        public string Operation { set => OrderPanel__TextOpreration.Text = value; }
        public string User { set => OrderPanel__OperatorFullName.Text = value; }



        #endregion

        
        public IVideoSource VideoSource { set => videoPlayer.VideoSource = value; }
        public bool DeviceManagerItem { set => deviceManagerItem.Enabled = value; }

        public event Action MakeSnapshot;
        public event Action ShowAppSetting;
        public event Action ShowDeviceManagerPanel;


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
            if (videoPlayer.VideoSource != null)
            {
                videoPlayer.SignalToStop();
                videoPlayer.WaitForStop();
                videoPlayer.Stop();
                videoPlayer.VideoSource = null;
            }           
        }

        private void ShowAppSetting_Click(object sender, EventArgs e)
        {
            ShowAppSetting();
        }

        private void ShowDeviceManagerPanel_Click(object sender, EventArgs e)
        {
            ShowDeviceManagerPanel();
        }
    }

    
}
