
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
    public partial class MainForm : Form
    {
        private Capture wcc;
        private ImageBrowser imgBrowser;
        OrderForm order;
        public MainForm()
        {
            InitializeComponent();
            order = new OrderForm();
        }

        

        /// <summary>
        /// включены ли элементы упрвления устройством
        /// </summary>
        public bool EnableDeviceControl { get => btnScreenCapture.Enabled; set {
               // btnScreenCapture.Enabled = ListCaptutreModes.Enabled = value; 
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            wcc = new Capture();
            // инициализация, проверка наличия подключенных камер.
            if (wcc.init(CamView,this))
            {
                btnScreenCapture.Enabled = true;
                wcc.UpdateListNameDevices();
            }
            // wcc.UpdateListNameDevices();
            //SettinAppPanel__FileDirView.Text = Properties.Settings.Default.FileDir;
        }
        
        string Path;
        /// <summary>
        /// Кнопка захвата
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnScreenCapture_Click(object sender, EventArgs e)
        {
            //string RootDir = @".\image\";
            string RootDir = Properties.Settings.Default.FileDir;
            string FileName = String.Format("{0}_{1}_{2}{3}","заказ", DateTime.Now.ToString().Replace(":", "-"), Guid.NewGuid(),".jpg");
            if (ScreenView.Image != null)
            {
                ScreenView.Image.Dispose();
            }          
            ScreenView.Image = (Bitmap)CamView.Image.Clone();
            try
            {
                Path = RootDir+ @"\";
                if (!Directory.Exists(Path))
                {
                    Directory.CreateDirectory(Path);
                }
                Path = Path + FileName;
                CamView.Image.Save(Path, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            catch (Exception)
            {
                MessageBox.Show("не удалось сохранить файл!");

            }
           

            this.PreviewPhotos();
        }

        ///
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (wcc.DevicesConnectedStatus)
            {
                wcc.SaveConfig();
                wcc.Stop();
            }
     
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            //var d = dataSet1BindingSource;


        }
        public void PreviewPhotos()
        {
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(100, 100);
            //imageList.Images.Add(new Bitmap(Path).GetThumbnailImage(100, 100, null, IntPtr.Zero));
            Image m = Image.FromFile(Path);
            //m.GetThumbnailImage(100, 100, null, IntPtr.Zero);
            imageList.Images.Add(m);
           // imageList.Dispose();
            //imageList.Images.Add(Image.FromFile(Path).GetThumbnailImage(100,100,null,IntPtr.Zero));



            Bitmap emptyImage = new Bitmap(100, 100);
            using (Graphics gr = Graphics.FromImage(emptyImage))
            {
                gr.Clear(Color.White);
            }

            photoGalleraya.SmallImageList = imageList;
            string[] order = { "100/28", "19.12.2019 11:38:26" };

            ListViewItem item = new ListViewItem(new string[] { "", order[0], order[1] });
            item.ImageIndex = 0;

            photoGalleraya.Items.Add(item);
            m.Dispose();
            m = null;
        }

        private void PhotoGalleraya_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(photoGalleraya.SelectedItems[0].);
            
        }

        private void КамераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingForm settingDev = new SettingForm();

            //settingDev.btnOkSettingDev.Enabled = false;
            settingDev.ListCaptureDevices.SelectedIndex = wcc.DeviceId;
            settingDev.ListCaptutreModes.SelectedIndex = wcc.ModeId;

            if (settingDev.ShowDialog() == DialogResult.OK)
            {
                
                wcc.Start(settingDev.Dev, settingDev.Mod);
            }
            
            
        }

        /// <summary>
        /// Обработчик выбора разрешения (режима) захвата из списка  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListCaptutreModes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //wcc.ChangeModeCapture(ListCaptutreModes.SelectedIndex);
        }
        //OrderForm order;
        private void BtnOrderEdit_Click(object sender, EventArgs e)
        {
            //order = new OrderForm();
            if (order.ShowDialog() == DialogResult.OK) 
            {
                OrderPanel__TextOrder.Text = order.Order;
                OrderPanel__TextRoller.Text = order.Roller;
                OrderPanel__TextOpreration.Text = order.Action;
                OrderPanel__TextUser.Text = order.User;
            }

           
                 
        }

        ListViewItem item;
        private void photoGalleraya_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            item = new ListViewItem(new string[] { "", "100/1/19", DateTime.Now.ToString() });
            item.ImageIndex = 0;

            e.Item = item;
            
        }

        private void photoGalleraya_CacheVirtualItems(object sender, CacheVirtualItemsEventArgs e)
        {
            
        }
    }

    
}
