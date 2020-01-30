using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebCamCapture.View;

namespace WebCamCapture
{
    static class Program
    {
        static Model.Pleer pleer;
        static Presenter.SettingPresenter settingPresenter;
        static Presenter.OrderPresenter orderPresenter;
        static Model.Order order;
        static View.OrderForm orderForm;
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
            view.OrderEditBtn += View_OrderEditBtn;
            order = new Model.Order();
            orderForm = new OrderForm();
            orderPresenter = new Presenter.OrderPresenter(orderForm, order);
            new Presenter.MainPresenter(view, pleer, order);
            settingPresenter = new Presenter.SettingPresenter();

            
            
           

            Application.Run(view);
           
        }

        private static void View_OrderEditBtn()
        {
            orderForm.ShowDialog();
            
        }

        // отобразить форму настроек
        private static void View_ShowSettingForm()
        {
            settingPresenter.Show(new SettingForm(), pleer);
        }
    }
}
