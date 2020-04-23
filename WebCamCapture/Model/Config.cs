using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCamCapture.Model
{
    public static class Config
    {
        /// <summary>
        /// путь к снимкам из настроек
        /// </summary>
        public static string SnapshotDir
        {
            get => Properties.Settings.Default.FileDir;
            set => Properties.Settings.Default.FileDir = value;
        }
        /// <summary>
        /// Шрифт вводного текста
        /// </summary>
        public static Font Font
        {
            get => Properties.Settings.Default.Font;
            set => Properties.Settings.Default.Font = value;
        }
        /// <summary>
        /// Разрешен водяной текст
        /// </summary>
        public static bool WaterText
        {
            get => Properties.Settings.Default.WaterText;
            set => Properties.Settings.Default.WaterText = value;
        }
    }

}
