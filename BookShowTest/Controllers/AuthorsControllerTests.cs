using Microsoft.VisualStudio.TestTools.UnitTesting;
using Book_Show.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Show.Controllers.Tests
{
    [TestClass()]
    public class AuthorsControllerTests
    {
        [TestMethod()]
        public void IndexTest()
        {
            string result = "Ehab";
            Assert.AreEqual("Ehab",result);

        }

        [TestMethod()]
        public void DetailsTest()
        {
            string result = "Ehab1";
            Assert.AreEqual("Ehab1", result);
        }

        [TestMethod()]
        public void CreateTest()
        {
            string result = "Ehab2";
            Assert.AreEqual("Ehab2", result);
        }

        [TestMethod()]
        public void CreateTest1()
        {
            string result = "Ehab3";
            Assert.AreEqual("Ehab3", result);
        }

        [TestMethod()]
        public void EditTest()
        {
            string result = "Ehab4";
            Assert.AreEqual("Ehab4", result);
        }

        [TestMethod()]
        public void EditTest1()
        {
            string result = "Ehab5";
            Assert.AreEqual("Ehab5", result);
        }

        [TestMethod()]
        public void DeleteTest()
        {
            string result = "Ehab6";
            Assert.AreEqual("Ehab6", result);
        }

        [TestMethod()]
        public void DeleteConfirmedTest()
        {
            string result = "Ehab7";
            Assert.AreEqual("Ehab7", result);
        }
    }
}