using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using LightInject;

namespace WebCamCapture
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var view = new View.MainForm();
            var pleer = new Model.Pleer();
            var presenter = new Presenter.MainPresenter(view, pleer);
            Application.Run(view);
           
        }

    }
}
