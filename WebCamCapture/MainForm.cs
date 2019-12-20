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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
           
        }

        private Capture wcc;
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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "orderDataSet2.user". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter.Fill(this.orderDataSet2.user);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "orderDataSet1.operation". При необходимости она может быть перемещена или удалена.
            this.operationTableAdapter.Fill(this.orderDataSet1.operation);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "orderDataSet.roller". При необходимости она может быть перемещена или удалена.
            this.rollerTableAdapter.Fill(this.orderDataSet.roller);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "orderDataSet.roller". При необходимости она может быть перемещена или удалена.
            this.rollerTableAdapter.Fill(this.orderDataSet.roller);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "orderDataSet.Order". При необходимости она может быть перемещена или удалена.

            wcc = new Capture();
            // инициализация, проверка наличия подключенных камер.
            if (wcc.init(CamView,this))
            {
                ListCaptureDevices.Items.AddRange(wcc.ListNameDevices.ToArray());

                ListCaptutreModes.Items.AddRange(wcc.ListVideoModes.ToArray());
                ListCaptutreModes.SelectedIndex = wcc.SelectedVideoMode;

                btnScreenCapture.Enabled = true;
                wcc.UpdateListNameDevices();
                ListCaptureDevices.SelectedIndex = wcc.SelectedDeviceIndex;
            }
           // wcc.UpdateListNameDevices();

        }
        string NameFile;
        string Path;
        /// <summary>
        /// Кнопка захвата
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnScreenCapture_Click(object sender, EventArgs e)
        {
            //string NameFile;
            //Path = @"image\";
            Directory.CreateDirectory(@"1\1");
            Path = String.Format("{0}{1}_{2}_{3}", @".\image\", DateTime.Now.ToString().Replace(":", "-"), DateTime.Now.Ticks,".jpg");
            NameFile = DateTime.Now.ToString().Replace(":", "-");
            NameFile += DateTime.Now.Ticks + ".jpg";
            NameFile = Path + "" + NameFile;
            if (ScreenView.Image != null)
            {
                ScreenView.Image.Dispose();
            }          
            ScreenView.Image = (Bitmap)CamView.Image.Clone();
            CamView.Image.Save(Path, System.Drawing.Imaging.ImageFormat.Jpeg);

            this.PreviewPhotos();
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
            wcc.UpdateListNameDevices();
            if (wcc.DevicesCounter > 0)
            {
                this.EnableDeviceControl = true;
                ListCaptureDevices.Items.Clear();
                ListCaptureDevices.Items.AddRange(wcc.ListNameDevices.ToArray());
                ListCaptureDevices.SelectedIndex = wcc.SelectedDeviceIndex;
            }
            else
            {
                this.EnableDeviceControl = false;
                ListCaptureDevices.Items.Clear();
            }

            // если устройства не подключены, отключаем контролы управления устройствами



            //ListCaptureDevices.Items.Clear();
            //ListCaptureDevices.Items.AddRange(wcc.ListNameDevices.ToArray());
            //ListCaptureDevices.Items.AddRange(wcc.ListNameDevices.ToArray());
            //ListCaptureDevices.SelectedIndex = wcc.SelectedDeviceIndex;

        }
       
        private void ListCaptureDevices_SelectionChangeCommitted(object sender, EventArgs e)
        {
            wcc.ChangeModeCapture(ListCaptutreModes.SelectedIndex);
            wcc.SelectedDeviceIndex = ListCaptureDevices.SelectedIndex;
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {

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


        private void НастройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("fdf", "gffg",MessageBoxButtons.YesNo);
        }

        private void ПутьСохраненияФайловToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void КамераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingDevice settingDev = new SettingDevice();
            settingDev.ShowDialog();
        }

        /// <summary>
        /// Обработчик выбора разрешения (режима) захвата из списка  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListCaptutreModes_SelectedIndexChanged(object sender, EventArgs e)
        {
            wcc.ChangeModeCapture(ListCaptutreModes.SelectedIndex);
        }

        private void BtnOrderEdit_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            orderForm.ShowDialog();
        }



        private void BtnCardOrderOk_Click(object sender, EventArgs e)
        {
            nomberOrderText.Text += " " +nomberOrder.Text;
            rollerNumberText.Text += " " + numberRollerList.Text;
            numberOprerationText.Text += " " + numberOperationList.Text;
            userCardText.Text += " " + userCardList.Text;
        } 
    }

    
}
