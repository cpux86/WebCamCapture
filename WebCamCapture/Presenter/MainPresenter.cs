using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using WebCamCapture.Model;
using WebCamCapture.View;

namespace WebCamCapture.Presenter
{
    class MainPresenter
    {
        readonly IVideoPlayerView mainForm;
        readonly FM fileManager;
        public MainPresenter(MainForm mainForm, FM fm)
        {
            this.mainForm = mainForm;
            this.fileManager = fm;
            mainForm.Load += MainForm_Load;
            mainForm.FormClosing += MainForm_FormClosing;
            mainForm.MakeSnapshot += MainForm_MakeSnapshot;
            //fm.NewImage += FileManager_NewImage;
            fm.NewFrame += Fm_NewFrame;


        }

        // Обработчик события поступления снимка для отображения 
        private void Fm_NewFrame(Image obj)
        {
            mainForm.ShowSnapshot(obj);
        }

        //// Обработчик события поступления снимка для отображения 
        //private void FileManager_NewImage(string img)
        //{
        //    //mainForm.SnapshotView(img);
        //}

        // Обработчик события "Создать снимок"
        private void MainForm_MakeSnapshot()
        {
            this.fileManager.CreateSnapshot();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.Stop();
            Properties.Settings.Default.Save();
        }

        
    }
}
