using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCamCapture.Model
{
    public static class Config
    {
        //public static string SnapshotFolder { get; set; }

        /// <summary>
        /// путь к снимкам из настроек
        /// </summary>
        public static string SnapshotDir
        {
            get => Properties.Settings.Default.FileDir;
            set => Properties.Settings.Default.FileDir = value;
        }

    }
}
