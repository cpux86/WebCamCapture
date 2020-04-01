using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using WebCamCapture.Presenter;

namespace WebCamCapture.Model
{
    public class FileManager
    {
        // путь к отслеживаемому каталогу
        private string path = @"d:\C#\WebCamCapture\WebCamCapture\bin\Debug\";

        /// <summary>
        /// Отслеживает содержимого каталога
        /// </summary>
        public void Monitor()
        {
            FileSystemWatcher watcher = new FileSystemWatcher();

            watcher.Path = path;
            watcher.Filter = "*.jpg";
            watcher.Created += Watcher_Created;
            watcher.Deleted += Watcher_Created;
            watcher.EnableRaisingEvents = true;
            watcher.IncludeSubdirectories = true;
        }
        // Обработчик события изменения содержимого каталога
        public void Watcher_Created(object sender, FileSystemEventArgs e)
        {
            System.Windows.Forms.MessageBox.Show(e.FullPath);
        }

        /// <summary>
        /// Создает уникальное имя для данного снимка, с текущими параметрами заказа
        /// </summary>
        /// <returns>уникальная строка для снимка</returns>
        public string CreateFileName()
        {
            string fileName;
            string dateTime = DateTime.Now.ToString("dd.MM.yyyy_HH.mm.ss.ffff");

            // [номер заказа][дата, время+мсек][ролик][процесс][исполнитель]
            fileName = String.Format(
                "{0}_{1}_{2}_{3}_{4}.jpg", 
                Order.OrderNumber, 
                dateTime, 
                Order.Roller,
                Order.Process,
                Order.User);
            return Validation(fileName);
        }
        /// <summary>
        /// Заменяет в переданной строке все не допустимые символы на "-"
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private string Validation(string s)
        {
            // Массив не допустимых символов
            string[] symbols = new string[] { "/", ":", "+" };

            foreach (string symbol in symbols)
            {
                s = s.Replace(symbol, "-");
            }
            return s;
        }

        public void Save()
        {

        }


    }
}
