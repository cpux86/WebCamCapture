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
        private IPlayerMainView mainForm;
        FileManager fileManager;
        public MainPresenter(MainForm mainForm, FileManager fileManager)
        {
            this.mainForm = mainForm;
            this.fileManager = fileManager;
            mainForm.Load += MainForm_Load;
            mainForm.FormClosing += MainForm_FormClosing;
            mainForm.MakeSnapshot += MainForm_MakeSnapshot;

        }
        // Обработчик события "Создать снимок"
        private void MainForm_MakeSnapshot()
        {
            fileManager.CreateSnapshot();
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
