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
            manager.AddUser("Мария");
            var res = manager.List();
            manager.SaveToFile();
        }
    }
}