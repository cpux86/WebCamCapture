using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCamCapture.Model
{
    interface ICapture
    {
        List<string> ListNameDevices { get; }
        List<string> ListVideoModes { get; }
        void Start(string DeviceName, string FrameSize);
        void Stop();
    }
}
