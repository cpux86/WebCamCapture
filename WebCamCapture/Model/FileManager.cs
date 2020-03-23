using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WebCamCapture.Presenter;

namespace WebCamCapture.Model
{
    public class FileManager
    {
        string fileName;
        public string FileName { get => fileName; }

        public void CreateFileName()
        {
            string dateTime = DateTime.Now.ToString("dd.MM.yyyy HH.mm.ss.ffff");

            // [номер заказа][дата, время][ролик][процесс][исполнитель]
            fileName = String.Format("{0}_{1}_{2}_{3}_{4}",Order.OrderNumber, dateTime, Order.Roller, Order.Process, Order.User);
            this.Validation();
        }

        public void Validation()
        {
            // Массив не допустимых символов
            string[] symbols = new string[] {"/", ":","+"};

            foreach (string symbol in symbols)
            {
                fileName = fileName.Replace(symbol, "_");
            }

        }


    }
}
