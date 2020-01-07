using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebCamCapture.View
{
    interface IMainView
    {
        /// <summary>
        /// Номер заказа
        /// </summary>
        string OrderNumber { set; }
        /// <summary>
        /// Номер ролика
        /// </summary>
        string RollerNumber { set; }
        /// <summary>
        /// Номер операции
        /// </summary>
        string ActionNumber { set; }
        /// <summary>
        /// Исполнитель Ф.И.О
        /// </summary>
        string OperatorFullName { set; }

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
