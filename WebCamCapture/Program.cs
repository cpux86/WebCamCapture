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
        static Presenter.SettingPresenter settingPresenter;
        static Presenter.OrderPresenter orderPresenter;
        static Model.OrderModel orderModel;
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
            new Presenter.MainPresenter(view, pleer);
            settingPresenter = new Presenter.SettingPresenter();

            orderForm = new OrderForm();
            orderModel = new Model.OrderModel();
            orderPresenter = new Presenter.OrderPresenter(orderForm, orderModel);

            Application.Run(view);
           
        }

        private static void View_OrderEditBtn()
        {
            var x = new OrderForm();
            x.ShowDialog();
            
        }

        // отобразить форму настроек
        private static void View_ShowSettingForm()
        {
            settingPresenter.Show(new SettingForm(), pleer);
        }
    }
}
