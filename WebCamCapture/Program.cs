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
        static Presenter.SettingPresenter playerSettingPresenter;
        static Presenter.OrderPresenter orderPresenter;
        static Model.OrderModel orderModel;
        static View.OrderForm orderForm;
        static View.SettingForm playerSettingForm;
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

            playerSettingForm = new SettingForm();
            new Presenter.MainPresenter(mainForm, pleerModel, orderModel);
            playerSettingPresenter = new Presenter.SettingPresenter(playerSettingForm, pleerModel);


            try
            {
                Application.Run(mainForm);
            }
            catch (InvalidOperationException e)
            {
                MessageBox.Show(e.Message);               
            }
            
           
        }
        // отобразить форму заказа
        private static void MainForm_OrderEditBtn()
        {
            orderForm.ShowDialog();       
        }

        // отобразить форму настроек
        private static void MainForm_ShowSettingForm()
        {
            // отображаем форму настроек 
            playerSettingPresenter.Show();
            
        }
    }
}
