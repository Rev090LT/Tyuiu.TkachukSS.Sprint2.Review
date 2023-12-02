using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TkachukSS.Sprint2.Review.Task7.V15.Lib;
namespace Tyuiu.TkachukSS.Sprint2.Review.Task7.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dt = new DataService();
            Assert.AreEqual(true, dt.CheckDotInShadedArea(1.3, 1));
        }
    }
}
