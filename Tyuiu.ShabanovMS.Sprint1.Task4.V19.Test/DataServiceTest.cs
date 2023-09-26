using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShabanovMS.Sprint1.Task4.V19.Lib;

namespace Tyuiu.ShabanovMS.Sprint1.Task4.V19.Test
{
    [TestClass]
    public class DataServiceTest 
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 4;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(5, res);
        }
    }
}
