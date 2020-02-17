
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
//using AForge.Video.DirectShow;
using Accord.Video;

namespace WebCamCapture.View
{
    interface IMain
    {
        event EventHandler Load;
        event FormClosingEventHandler FormClosing;
    }

    internal interface IPlayer : IMain
    {
        IVideoSource VideoSource { set; }
        Image CurrentFrame { get; }
        void Start();
        void Stop();

    }

    internal partial class MainForm : Form, IMain, IPlayer
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

        public Image CurrentFrame => videoPlayer.GetCurrentVideoFrame();

        private void makeSnapshotBtn_Click(object sender, EventArgs e)
        {
            snapshotView.Image = videoPlayer.GetCurrentVideoFrame();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

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
    }

    
}
