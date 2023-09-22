using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShabanovMS.Sprint1.Task2.V23.Lib;
namespace Tyuiu.ShabanovMS.Sprint1.Task2.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 2;
            double x = 60;
            var res = ds.Calculate(a, x);
            Assert.AreEqual(120, res);
        }
    }
}
