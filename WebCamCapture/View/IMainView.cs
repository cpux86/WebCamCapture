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
        Image ScreenView { get; set; }
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
        /// Возникает при клике по кнопке создания Скриншота
        /// </summary>
        event EventHandler ScreenCapture;
        Form GetContext { get; }
        /// <summary>
        /// Отобразить кадр
        /// </summary>
        void ViewFrame();
    }
}
