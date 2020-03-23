using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebCamCapture.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCamCapture.Presenter;


namespace WebCamCapture.Model.Tests
{
    [TestClass()]
    public class FileManagerTests
    {
        [TestMethod()]
        public void CreateFileNameTest()
        {
            Order.OrderNumber = "10/10111";
            FileManager fileManager = new FileManager();
            
            fileManager.CreateFileName();
            var x = fileManager.FileName;

        }
    }
}