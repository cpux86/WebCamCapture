
using Accord.Video;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using WebCamCapture.Model;
using WebCamCapture.Presenter;

namespace WebCamCapture.View
{

    public interface IMain
    {
        string AppRoot { get; }
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
    interface IVideoPlayerView : IMain
    {
        IVideoSource VideoSource { set; }
        void Start();
        void Stop();
        bool IsRunning { get; }

        void ShowSnapshot(Image img);


    }
    public interface IOrderMainForm : IMain
    {
        string OrderNumber { set; }
        string Roller { set; }
        string Process { set; }
        string User { set; }
        /// <summary>
        /// Отображение формы заказа
        /// </summary>
        event Action ShowOrderForm;
    }

    public interface IGallery : IMain
    {
        int Count { get; }
        void Add(List<Snapshot> list);
        void Remove();
        void Clear();
    }

    internal partial class MainForm : Form, IVideoPlayerView, IOrderMainForm, IGallery
    {
        public MainForm()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        #region Сведения о заказе
        public string OrderNumber { set => TextOrderMainForm.Text = value; }
        public string Roller { set => TextRollerMainForm.Text = value; }
        public string Process { set => TextOprerationMainForm.Text = value; }
        public string User { set => OperatorFullNameMainForm.Text = value; }



        #endregion


        public IVideoSource VideoSource { set => videoPlayer.VideoSource = value; }
        public bool DeviceManagerItem { set => deviceManagerItem.Enabled = value; }

        public event Action MakeSnapshot;
        public event Action ShowAppSetting;
        public event Action ShowDeviceManagerPanel;
        public event Action ShowOrderForm;

        /// <summary>
        /// Корневой каталог приложения
        /// </summary>
        public string AppRoot { get => Application.StartupPath; }

        private void makeSnapshotBtn_Click(object sender, EventArgs e)
        {
            MakeSnapshot();
        }



        public bool IsRunning { get => videoPlayer.IsRunning; }

        public int Count => throw new NotImplementedException();

        public void Start()
        {
            videoPlayer.Start();
        }

        public void Stop()
        {
            Invoke((MethodInvoker)(() =>
            {
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


        public void ShowSnapshot(Image img)
        {
            Invoke((MethodInvoker)(() =>
            {
                if (snapshotView.Image != null)
                {
                    snapshotView.Image.Dispose();
                    snapshotView.Image = null;
                }

                snapshotView.Image = (Bitmap)img.Clone();


            }));
        }

        // Отобразить форму заказа
        private void OrderEditBtn_Click(object sender, EventArgs e)
        {
            ShowOrderForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        #region Фотогалерея

        public void Add(List<Snapshot> list)
        {
          
        }

        public void Remove()
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        

        #endregion
    }


}