using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebCamCapture.Model;

namespace WebCamCapture.View
{
    interface IMainView : IView
    {
        /// <summary>
        /// Номер заказа
        /// </summary>
        string OrderNumber { set; }
        /// <summary>
        /// Номер ролика
        /// </summary>
        string Roller { set; }
        /// <summary>
        /// Номер операции
        /// </summary>
        string Operation { set; }
        /// <summary>
        /// Исполнитель Ф.И.О
        /// </summary>
        string User { set; }

        /// <summary>
        /// Возникает при щелчке по кнопке создания снимка
        /// </summary>
        event Action MakeSnapshot;

        /// <summary>
        /// Возникает при клике на кнопку Настройки
        /// </summary>
        event Action ShowSettingForm;

        Form GetContext { get; }
        /// <summary>
        /// Отобразить новый кадр
        /// </summary>
        void ShowNewFrame(Image frame);
        /// <summary>
        /// Показать захваченный снимок
        /// </summary>
        Image ShowSnapshot { set; }
    }
}
