using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCamCapture.View
{
    interface ISetting
    {
        event Action SettingOk;
        int DeviceIndex { get; set; }
        int ModeIndex { get; set; }
        string[] DeviceList { set; }
        string[] ModesList { set; }
        /// <summary>
        /// Путь к папке со снимкаи
        /// </summary>
        string SnapshotFolder { get; set; }
        string SnapshotFolderTextBox { set; }
    }
}
