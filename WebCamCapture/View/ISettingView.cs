﻿using System;
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
        /// Путь к папке со снимкаи
        /// </summary>
        string SnapshotFolder { get; set; }
        string SnapshotFolderTextBox { set; }
        DialogResult ShowDialog();
        void Close();
    }
}