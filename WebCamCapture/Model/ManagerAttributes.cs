using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace WebCamCapture.Model
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

        public void AutoClean(int maxValue)
        {
            int listLenght = this.attributesList.Count;
            if (listLenght > maxValue)
            {
                int i = maxValue;
                int c = listLenght - maxValue;
                this.attributesList.RemoveRange(i, c);
            }
            
        }

        /// <summary>
        /// Добовляет в список, заначение value, если value есть в списке, то возвращает ее id.
        /// </summary>
        /// <param name="value">Добовляемая строка</param>
        /// <returns>id стороки в списке</returns>
        public int Add(string value)
        {
            int id = this.attributesList.IndexOf(value);
            if (id == -1 && value != "")
            {
                // помещаем новый элемент в начало списка
                this.attributesList.Insert(0,value);
                // возращаем индекс нового элемента
                return 0;
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
    public class ManagerAttributes
    {
        #region Настройки размера списка
        /// <summary>
        /// Максимальный размер списка заказов
        /// </summary>
        static int ordersMaxList = 10;
        static int rollerMaxList = 30;
        static int processMaxList = 20;
        static int usersMaxList = 25;

        #endregion


        private string fileBin = "User.dat";

        readonly Attribute order;
        readonly Attribute roller;
        readonly Attribute process;
        readonly Attribute user;
       

        private Attributes attributes;

        public ManagerAttributes()
        {
            order = new Attribute();
            roller = new Attribute();
            process = new Attribute();
            user = new Attribute();

            attributes = new Attributes();


            attributes.List = new List<Attribute>();
            attributes.List.Add(order);
            attributes.List.Add(roller);
            attributes.List.Add(process);
            attributes.List.Add(user);
            
            this.Init();
            
        }
        #region Добавить, удалить атрибуты
        public Attribute Order()
        {
            order.AutoClean(ordersMaxList);
            return order;
        }
        public Attribute Roller()
        {
            roller.AutoClean(rollerMaxList);
            return roller;
        }

        public Attribute Process()
        {
            process.AutoClean(processMaxList);
            return process;
        }

        public Attribute User()
        {
            user.AutoClean(usersMaxList);
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
            formatter.Serialize(stream, this);
            stream.Close();
        }
        ManagerAttributes manager;
        /// <summary>
        /// Загрузить сохраненные атрибуты
        /// </summary>
        public ManagerAttributes Init()
        {

            try
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(fileBin, FileMode.Open, FileAccess.Read, FileShare.Read);
                manager = (ManagerAttributes)formatter.Deserialize(stream);
                stream.Close();
            }
            catch (Exception)
            {

                return this;
            }
            return manager;
        }

    }
}
