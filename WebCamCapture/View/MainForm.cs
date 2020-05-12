using Accord.Video;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using WebCamCapture.Model;

namespace WebCamCapture.View
{

    public interface IMain
    {
        //string AppRoot { get; }
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

        //void ShowSnapshot(Image img);
        void ShowSnapshot(ISnapshot img);


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

    public interface IGallery
    {
        //int Count { get; }
        void Add(BindingList<Snapshot> list);
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
        public string OrderNumber { set => orderLbl.Text = value; }
        public string Roller { set => rollerLbl.Text = value; }
        public string Process { set => processLbl.Text = value; }
        public string User { set => userLbl.Text = value; }



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
        //public string AppRoot { get => Application.StartupPath; }

        private void makeSnapshotBtn_Click(object sender, EventArgs e)
        {
            MakeSnapshot();
        }



        public bool IsRunning { get => videoPlayer.IsRunning; }


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


        //public void ShowSnapshot(Image img)
        //{
        //    Invoke((MethodInvoker)(() =>
        //    {
        //        if (snapshotView.Image != null)
        //        {
        //            snapshotView.Image.Dispose();
        //            snapshotView.Image = null;
        //        }

        //        snapshotView.Image = (Bitmap)img.Clone();


        //    }));
        //}

        /// <summary>
        /// Отобразить снимок и сведения о заказе
        /// </summary>
        /// <param name="s"></param>
        public void ShowSnapshot(ISnapshot s)
        {
            Invoke((MethodInvoker)(() =>
            {
                if (snapshotView.Image != null)
                {
                    snapshotView.Image.Dispose();
                    snapshotView.Image = null;
                }

                snapshotView.Image = (Bitmap)s.Image.Clone();
                orderLbl.Text = s.OrderNumber;
                rollerLbl.Text = s.Roller;
                processLbl.Text = s.Process;
                userLbl.Text = s.User;
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

        public void Add(BindingList<Snapshot> list)
        {
            Invoke((MethodInvoker)(() =>
            {
                dataGridView1.DataSource = list;
            }));
            
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