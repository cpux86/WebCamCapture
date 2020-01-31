using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCamCapture.View
{
    public interface IOrderView
    {
        string[] RollerList { set; }
        string[] OperationsList { set; }
        string[] UsersList { set; }

        string Order { get; set; }
        string SelectedRoller { get; }
        string SelectedOperation { get; }
        string SelectedUser { get; }
        /// <summary>
        /// Щелчок по кнопке Ok формы заказа
        /// </summary>
        event Action BtnOkOrderClick;

    }
}
