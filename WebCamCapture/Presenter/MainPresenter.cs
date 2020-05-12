using System;
using System.Drawing;
using System.Windows.Forms;
using WebCamCapture.Model;
using WebCamCapture.View;

namespace WebCamCapture.Presenter
{
    class MainPresenter
    {
        //readonly IVideoPlayerView mainForm;
        readonly MainForm mainForm;
        readonly FM fm;
        public MainPresenter(MainForm mainForm, FM img)
        {
            this.mainForm = mainForm;
            this.fm = img;
            mainForm.FormClosing += MainForm_FormClosing;
            mainForm.MakeSnapshot += MainForm_MakeSnapshot;
            fm.NewPhoto += Fm_NewPhoto;
        }
        // Обработчик события поступления снимка для отображения 
        private void Fm_NewPhoto(ISnapshot s)
        {
            // 
            this.ShowSnapshot(s);
        }
        // Получить снимок для отображения
        private void ShowSnapshot(ISnapshot s)
        {
            //mainForm.ShowSnapshot(s.Image);
            //mainForm.OrderNumber = s.OrderNumber;
            mainForm.ShowSnapshot(s);
        }


        // Обработчик события "Создать снимок"
        private void MainForm_MakeSnapshot()
        {
            this.fm.Create();         
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.Stop();
            Properties.Settings.Default.Save();
        }


    }
}
