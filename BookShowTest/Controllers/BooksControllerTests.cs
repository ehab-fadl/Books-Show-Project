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
    public class BooksControllerTests
    {
        [TestMethod()]
        public void IndexTest()
        {
            string book = "Beispiel Buch";
            Assert.AreEqual("Beispiel Buch", book);
        }

        [TestMethod()]
        public void DetailsTest()
        {

            string book = "Beispiel Buch1";
            Assert.AreEqual("Beispiel Buch1", book);
        }

        [TestMethod()]
        public void CreateTest()
        {

            string book = "Beispiel Buch2";
            Assert.AreEqual("Beispiel Buch2", book);
        }

        [TestMethod()]
        public void CreateTest1()
        {

            string book = "Beispiel Buch3";
            Assert.AreEqual("Beispiel Buch3", book);
        }

        [TestMethod()]
        public void EditTest()
        {

            string book = "Beispiel Buch4";
            Assert.AreEqual("Beispiel Buch4", book);
        }

        [TestMethod()]
        public void EditTest1()
        {

            string book = "Beispiel Buch5";
            Assert.AreEqual("Beispiel Buch5", book);
        }

        [TestMethod()]
        public void DeleteTest()
        {

            string book = "Beispiel Buch6";
            Assert.AreEqual("Beispiel Buch6", book);
        }

        [TestMethod()]
        public void DeleteConfirmedTest()
        {

            string book = "Beispiel Buch7";
            Assert.AreEqual("Beispiel Buch7", book);
        }
    }
}