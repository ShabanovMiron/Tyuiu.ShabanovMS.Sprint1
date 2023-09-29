using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShabanovMS.Sprint1.Task7.V11.Lib;
namespace Tyuiu.ShabanovMS.Sprint1.Task7.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 3;
            double wait = 1.751;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(res, wait);
        }
    }
}
