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
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var mainForm = new View.MainForm();
            var settingForm = new View.SettingForm();
            
            Presenter.MainPresenter mainPresenter = new Presenter.MainPresenter(mainForm);
            Presenter.SettingPresenter settingPresenter = new Presenter.SettingPresenter(mainForm, settingForm);
            Presenter.OrderPresenter orderPresenter = new Presenter.OrderPresenter(mainForm);

            Application.Run(mainForm);
        }
    }
}
