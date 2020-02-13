﻿
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
    internal partial class MainForm : Form, IMainView
    {
        public MainForm()
        {
            InitializeComponent();
            makeSnapshotBtn.Click += (sender, args) => invoke(MakeSnapshot);
            showSettingBtn.Click += (sender, arges) => invoke(ShowSettingForm);
            orderEditBtn.Click += (sender, arges) => invoke(OrderEditBtn);
            this.KeyPreview = true;
        }


        public string OrderNumber { set => OrderPanel__TextOrder.Text = value; }
        public string Roller { set => OrderPanel__TextRoller.Text = value; }
        public string Operation { set => OrderPanel__TextOpreration.Text = value; }
        public string User { set => OrderPanel__OperatorFullName.Text = value; }

        public event Action MakeSnapshot;
        public event Action ShowSettingForm;
        public event Action OrderEditBtn;

        public Form GetContext { get => this; }




        private void invoke(Action action)
        {
            if (action != null)
            {
                action();
            }
        }

        private void VideoPlayer_NewFrame(object sender, ref Bitmap image)
        {
            //videoPlayer.
        }

        public void Start()
        {
            videoPlayer.Start();
        }

        public void Stop()
        {
            videoPlayer.SignalToStop();
            videoPlayer.WaitForStop();
            videoPlayer.VideoSource = null;
        }

        /// <summary>
        /// Возращает копию текущего кадра в плеере
        /// </summary>
        /// <returns></returns>
        public Image GetCurrentFrame()
        {
            return videoPlayer.GetCurrentVideoFrame();
        }
    }




}
