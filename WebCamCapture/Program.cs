﻿using System;
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
        static Presenter.PlayerSettingPresenter playerSettingPresenter;
        static Presenter.OrderPresenter orderPresenter;
        static Model.OrderModel orderModel;
        static View.OrderForm orderForm;
        static View.PlayerSettingForm playerSettingForm;
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

            playerSettingForm = new PlayerSettingForm();
            new Presenter.MainPresenter(mainForm, pleerModel, orderModel);
            playerSettingPresenter = new Presenter.PlayerSettingPresenter(playerSettingForm, pleerModel);

            
            
           

            Application.Run(mainForm);
           
        }

        private static void MainForm_OrderEditBtn()
        {
            orderForm.ShowDialog();
            
        }

        // отобразить форму настроек
        private static void MainForm_ShowSettingForm()
        {
            // перезагрузка данные из модели для формы
            playerSettingPresenter.Reload();
            // отображаем форму настроек 
            playerSettingForm.ShowDialog();
        }
    }
}
