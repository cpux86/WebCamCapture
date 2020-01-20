using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using LightInject;
using WebCamCapture.View;

namespace WebCamCapture
{
    static class Program
    {
        static Model.Pleer pleer;
        static Presenter.SettingPresenter presenter;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var view = new View.MainForm();
            pleer = new Model.Pleer();
            view.ShowSettingForm += View_ShowSettingForm;

            new Presenter.MainPresenter(view, pleer);
            presenter = new Presenter.SettingPresenter();
            Application.Run(view);
           
        }

        private static void View_ShowSettingForm()
        {
            presenter.Show(new SettingForm(), pleer);
        }
    }
}
