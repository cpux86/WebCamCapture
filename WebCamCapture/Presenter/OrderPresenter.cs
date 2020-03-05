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
    public class Attribute
    {
        private List<string> attributesList;
        public Attribute()
        {
            attributesList = new List<string>();
        }
        // возвращает индекс пользователя в списке, если его нет, то добавляем 
        public int Add(string name)
        {
            int id = this.attributesList.IndexOf(name);
            if (id == -1)
            {
                // если переданного параметра (neme) нет в списке, то добавляем его 
                this.attributesList.Add(name);
                id = this.attributesList.Count - 1;
            }
            return id;
        }
        public List<string> List()
        {
            return attributesList;
        }
    }
    [Serializable]
    public class Attributes
    {
        public List<string> UserList { get; set; }
        public List<string> RollerList { get; set; }
    }

    [Serializable]
    class OrderAttributes
    {
        // Состояние
        public string[] RollerList { get; set; }
        public string[] OperationsList { get; set; }
        protected List<string> UsersList { get; set; }
    }

    internal class AttributesManager : OrderAttributes
    {
        public AttributesManager()
        {
            UsersList = new List<string>();
        }
        // возвращает индекс пользователя в списке, если его нет, то добавляем 
        public int User(string name)
        {
            int id = this.UsersList.IndexOf(name);
            if (id == -1)
            {
                // если переданного параметра (neme) нет в списке, то добавляем его 
                this.UsersList.Add(name);
                id = this.UsersList.Count - 1;
            }
            return id;
        }
        // сохранить занчение атрибутов в файле (Сериализация)
        public void SaveToFile()
        {

        }
    }

    class OrderPresenter
    {
        //private string SelectedRoller => throw new NotImplementedException();
        //private string SelectedOperation => throw new NotImplementedException();
        //private string SelectedUser => throw new NotImplementedException();

        private string fileBin = "MyFile.bin";

        readonly private IOrderMainForm mainForm;
        AttributesManager manager;
        OrderAttributes order;
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
                var i = manager.User(orderForm.SelectedUser);
                var t = 0;
                #endregion
            }
        }
    }
}
