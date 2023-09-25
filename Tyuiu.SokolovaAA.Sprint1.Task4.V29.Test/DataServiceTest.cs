using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SokolovaAA.Sprint1.Task4.V29.Lib;
namespace Tyuiu.SokolovaAA.Sprint1.Task4.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 4;
            double y = 1;
            double wait = 2.667;
            var res = ds.Calculate( x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
