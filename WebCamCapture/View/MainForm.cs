
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
        }

        Image IMainView.ScreenView { get => ScreenView.Image; set => ScreenView.Image = value; }

        public string OrderNumber { set => OrderPanel__TextOrder.Text = value; }
        public string RollerNumber { set => OrderPanel__TextRoller.Text = value; }
        public string ActionNumber { set => OrderPanel__TextOpreration.Text = value; }
        public string OperatorFullName { set => OrderPanel__OperatorFullName.Text = value; }

        public event EventHandler ScreenCapture;
        
        public Form GetContext { get => this; } 

        private void btnScreenCapture_Click(object sender, EventArgs e)
        {
            btnScreenCapture.Click += BtnScreenCapture_Click;
        }

        private void BtnScreenCapture_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ScreenCapture.Invoke(sender, e);
        }

        public void ViewFrame()
        {
            
        }
    }

    
}
