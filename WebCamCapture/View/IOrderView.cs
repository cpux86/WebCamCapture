using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCamCapture.View
{
    public interface IOrderView
    {
        string[] OrderList { set; }
        string[] RollerList { set; }
        string[] OperationList { set; }
        string[] UserList { set; }

        string Order { get; }
        string Roller { get; }
        string Action { get; }
        string User { get; }

    }
}
