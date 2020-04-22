using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebCamCapture.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCamCapture.Model.Tests
{
    [TestClass()]
    public class WatcherTests
    {
        [TestMethod()]
        public void WatcherTest()
        {
            //Assert.Fail();
        }

        [TestMethod()]
        public void RunTest()
        {
            Watcher watcher = new Watcher();
            watcher.Run();
        }
    }
}