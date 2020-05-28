using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using WebCamCapture.Model;
using WebCamCapture.View;

namespace WebCamCapture.Presenter
{
    class MainPresenter
    {
        //readonly IVideoPlayerView mainForm;
        readonly List<ISnapshot> _snapshots;
        readonly MainForm mainForm;
        readonly FM fm;
        public MainPresenter(MainForm mainForm, FM img)
        {
            this.mainForm = mainForm;
            this.fm = img;
            mainForm.FormClosing += MainForm_FormClosing;
            mainForm.MakeSnapshot += MainForm_MakeSnapshot;
            fm.NewPhoto += Fm_NewPhoto;
            _snapshots = new List<ISnapshot>();
        }
        // Обработчик события поступления снимка
        private void Fm_NewPhoto(ISnapshot s)
        {
            // 
            this.ShowSnapshot(s);
            _snapshots.Add(s);
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
