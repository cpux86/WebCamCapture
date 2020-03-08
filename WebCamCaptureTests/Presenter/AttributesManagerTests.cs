using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebCamCapture.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCamCapture.Presenter.Tests
{
    [TestClass()]
    public class AttributesManagerTests
    {
        [TestMethod()]
        public void SaveToFileTest()
        {
            AttributesManager manager = new AttributesManager();
            manager.AddUser("Владимир");
            manager.AddUser("Мария2222222222222222222");
            var i = manager.AddUser("1111111111111111111111");

            var res = manager.UserList();

            manager.RemoveUser("Владимир");
            manager.SaveToFile();
        }
    }
}