using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCamCapture.View
{
    public interface IOrderView
    {
        string Order { get; set; }
        string Roller { get; set; }
        string Action { get; set; }
        string User { get; set; }

    }
}
