using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SokolovaAA.Sprint1.Task2.V12.Lib;
namespace Tyuiu.SokolovaAA.Sprint1.Task2.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int a = 9;
            int b = 6;
            int c = 3;
            var res = ds.CalculateParallelepipedVolume(a,b,c);
            Assert.AreEqual(162, res);
        }
    }
}