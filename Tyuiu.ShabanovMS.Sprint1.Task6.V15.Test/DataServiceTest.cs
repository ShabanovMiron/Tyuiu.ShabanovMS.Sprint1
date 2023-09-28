using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShabanovMS.Sprint1.Task6.V15.Lib;
namespace Tyuiu.ShabanovMS.Sprint1.Task6.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string value = "Больше букв чем символов!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!"; 
            bool res = ds.CheckLettersCount(value);
            bool wait = true;
            Assert.AreEqual(res, wait);
        }
    }
}
