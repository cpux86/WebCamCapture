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
        static Model.PlayerModel pleerModel;
        static Presenter.PlayerSettingPresenter settingPresenter;
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
            var mainForm = new View.MainForm();
            pleerModel = new Model.PlayerModel();
            mainForm.ShowSettingForm += MainForm_ShowSettingForm;
            mainForm.OrderEditBtn += MainForm_OrderEditBtn;
            orderModel = new Model.OrderModel();


            orderForm = new OrderForm();
            orderPresenter = new Presenter.OrderPresenter(orderForm, orderModel);


            new Presenter.MainPresenter(mainForm, pleerModel, orderModel);
            settingPresenter = new Presenter.PlayerSettingPresenter();

            
            
           

            Application.Run(mainForm);
           
        }

        private static void MainForm_OrderEditBtn()
        {
            orderForm.ShowDialog();
            
        }

        // отобразить форму настроек
        private static void MainForm_ShowSettingForm()
        {
            settingPresenter.Show(new PlayerSettingForm(), pleerModel);
        }
    }
}
