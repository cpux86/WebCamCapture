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
            var i = manager.Roller().Add("600");
            var i1 = manager.Roller().Add("70444444444444444444444440");
            manager.Roller().Remove("600");
            var z = manager.attributes;
            var list = manager.Roller().List();
            manager.SaveToFile();
        }
    }
}