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
        private IVideoPlayerView mainForm;
        FM fileManager;
        public MainPresenter(MainForm mainForm, FM fileManager)
        {
            this.mainForm = mainForm;
            this.fileManager = fileManager;
            mainForm.Load += MainForm_Load;
            mainForm.FormClosing += MainForm_FormClosing;
            mainForm.MakeSnapshot += MainForm_MakeSnapshot;
            fileManager.NewImage += FileManager_NewImage;

        }

        private void FileManager_NewImage(string obj)
        {
            mainForm.SnapshotView(obj);
        }

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
