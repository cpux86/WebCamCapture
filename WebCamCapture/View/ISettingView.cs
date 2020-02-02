using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebCamCapture.View
{
    interface ISettingView
    {
        int DeviceIndex { get; set; }
        int ModeIndex { get; set; }
        string[] DeviceList { set; }
        string[] ModesList { set; }
        /// <summary>
        /// выбранно новое устройство
        /// </summary>
        event Action DeviceIdChange;
        /// <summary>
        /// Выбран другой режим
        /// </summary>
        event Action ModeIdChange;
        
        /// <summary>
        /// Путь к папке со снимкаи
        /// </summary>
        string SnapshotFolder { get; set; }
        string SnapshotFolderTextBox { set; }
        DialogResult ShowDialog();
        void Close();
    }
}
