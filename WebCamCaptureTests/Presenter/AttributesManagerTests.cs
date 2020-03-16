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
        public void Save()
        {
            AttributesManager manager = new AttributesManager().Init();
            manager.User().Add("Владимир");
            manager.User().Add("Мария");
            manager.User().Add("Максим");

            manager.Process().Remove("Майка");
            manager.Process().Add("Мойка");
            manager.Process().Add("Сушка");

            manager.Save();
        }

        [TestMethod]
        public void Load()
        {
            AttributesManager manager = new AttributesManager().Init();
            string[] users = manager.User().List();
            string[] process = manager.Process().List();
            manager.User().Add("Владимир");
            manager.Save();
        }
    }
}