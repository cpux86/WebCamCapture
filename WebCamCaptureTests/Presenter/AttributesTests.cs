using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebCamCapture.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;

namespace WebCamCapture.Presenter.Tests
{
    [TestClass()]
    public class AttributesTests
    {
        Attributes attributes;
        public AttributesTests()
        {
            attributes = new Attributes();
            
        }
        [TestMethod()]
        public void AddUserTest()
        {
            var user = new Attribute();
            var roller = new Attribute();
            user.Add("Владимир");
            user.Add("Мария");
            attributes.UserList = user.List();
            roller.Add("800");
            roller.Add("850");
            attributes.RollerList = roller.List();

            //IFormatter formatter = new BinaryFormatter();
            //Stream stream = new FileStream(fileBin, FileMode.Create, FileAccess.Write, FileShare.None);
            //formatter.Serialize(stream, attributes);
            //stream.Close();
            SaveTest();
        }
        private string fileBin = "MyFile.bin";
        [TestMethod]
        public void SaveTest()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(fileBin, FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, attributes);
            stream.Close();
        }
    }
}