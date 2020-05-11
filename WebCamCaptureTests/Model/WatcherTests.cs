using Microsoft.VisualStudio.TestTools.UnitTesting;

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