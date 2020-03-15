using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCamCapture.View;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace WebCamCapture.Presenter
{
    // класс подлежащий сериализации
    [Serializable]
    public class Attributes
    {
        public List<Attribute> List { get; set; }
    }

    [Serializable]
    public class Attribute
    {
        private List<string> attributesList;
        public Attribute()
        {
            attributesList = new List<string>();
        }

        /// <summary>
        /// Добовляет в список, заначение value, если value есть в списке, то возвращает ее id.
        /// </summary>
        /// <param name="value">Добовляемая строка</param>
        /// <returns>id стороки в списке</returns>
        public int Add(string value)
        {
            int id = this.attributesList.IndexOf(value);
            if (id == -1)
            {
                // если переданного параметра (neme) нет в списке, то добавляем его 
                this.attributesList.Add(value);
                id = this.attributesList.Count - 1;
            }
            return id;
        }
        /// <summary>
        /// Удаляет из списка строку value
        /// </summary>
        /// <param name="value">удаляемая строка</param>
        /// <returns>результат удаления</returns>
        public bool Remove(string value)
        {
            return this.attributesList.Remove(value);
        }
        /// <summary>
        /// Возвращает список в виде массива
        /// </summary>
        /// <returns></returns>
        public string[] List()
        {
            return attributesList.ToArray();
        }

    }
    [Serializable]
    public class AttributesManager
    {
        private string fileBin = "MyFile.bin";

        readonly Attribute roller;
        readonly Attribute process;
        readonly Attribute user;
        private Attributes attributes;
       
        public AttributesManager()
        {
            process = new Attribute();
            roller = new Attribute();
            user = new Attribute();

            //attributes = new Attributes();
            this.LoadSavedAttributes();

            //attributes.List = new List<Attribute>();
            
            attributes.List.Add(process);
            attributes.List.Add(roller);
            attributes.List.Add(user);
        }
        #region Добавить, удалить атрибуты

        public Attribute Process()
        {
            return process;
        }


        public Attribute Roller()
        {
            return roller;
        }

        public Attribute User()
        {
            return user;
        }




        #endregion


        /// <summary>
        /// сохранить занчение атрибутов в файле (Сериализация)
        /// </summary>
        public void Save()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(fileBin, FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, attributes);
            stream.Close();
        }
        /// <summary>
        /// Загрузить сохраненные атрибуты
        /// </summary>
        public void LoadSavedAttributes()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(fileBin, FileMode.Open, FileAccess.Read, FileShare.Read);
            this.attributes = (Attributes)formatter.Deserialize(stream);
            stream.Close();
        }


    }

    class OrderPresenter
    {
        private string fileBin = "MyFile.bin";

        readonly private IOrderMainForm mainForm;
        AttributesManager manager;
        public OrderPresenter(IOrderMainForm mainForm)
        {
            this.mainForm = mainForm;
            this.mainForm.ShowOrderForm += ShowOrderForm;
            manager = new AttributesManager();
            try
            {
                //this.LoadAttributes();
            }
            catch (Exception)
            {

                manager = new AttributesManager();
            }
            mainForm.FormClosing += MainForm_FormClosing;
            
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.SaveAttributes();
        }

        #region Упрвление атрибутами Order
        // 
        private void LoadAttributes()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(fileBin, FileMode.Open, FileAccess.Read, FileShare.Read);
            manager = (AttributesManager)formatter.Deserialize(stream);
            stream.Close();
        }
        //
        private void SaveAttributes()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(fileBin, FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, manager);
            stream.Close();
        }
        #endregion

        private void ShowOrderForm()
        {
            IOrderForm orderForm = new OrderForm();
            #region Установить данные для формы
            //order.UsersList = new string[] { "Владимир","Мария"};
            //orderForm.UsersList = order.UsersList;
            #endregion

            this.mainForm.User = "Каськов В.В";
            if (orderForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                #region Получить данные из формы

                #endregion
            }
        }
    }
}
