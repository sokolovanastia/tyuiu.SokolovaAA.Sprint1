using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SokolovaAA.Sprint1.Task5.V1.Lib;
namespace Tyuiu.SokolovaAA.Sprint1.Task5.V1.Test
{
    [TestClass]
    public class DataServuceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x1 = 1;
            double y1 = 1;
            double x2 = 1;
            double y2 = 1;
            var res = ds.DistanceBetweenDots(x1, y1, x2, y2);
            Assert.AreEqual(0, res);
        }
    }
}
