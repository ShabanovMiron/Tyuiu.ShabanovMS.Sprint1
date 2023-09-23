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
            int x = 60;
            int value = 2;
            var res = ds.ConvertMinutesToSeconds(value);
            Assert.AreEqual(120, res);
        }
    }
}
