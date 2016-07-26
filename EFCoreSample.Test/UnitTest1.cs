using System;
using System.Linq;
using EFCoreSample.Entity;
using EFCoreSample.Test.Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EFCoreSample.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var db = new TestDatabaseContext();
            db.Books.Add(new Book() { Title = "TEST" });
            db.SaveChanges();

            var book = db.Books.First();
            Assert.AreEqual("TEST", book.Title);
            Assert.AreEqual(1, book.Id);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var db = new TestDatabaseContext();
            db.Books.Add(new Book() { Title = "TEST" });
            db.SaveChanges();

            var book = db.Books.First();
            Assert.AreEqual("TEST", book.Title);
            Assert.AreEqual(1, book.Id);
        }
    }
}
