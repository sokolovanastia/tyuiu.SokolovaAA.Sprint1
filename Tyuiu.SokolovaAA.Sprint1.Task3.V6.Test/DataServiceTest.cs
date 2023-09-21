using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SokolovaAA.Sprint1.Task3.V6.Lib;
namespace Tyuiu.SokolovaAA.Sprint1.Task3.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double distance = 67;
            double gasFlow = 8.5;
            double gasPrice = 6.5;
            double wait = 6;
            var res = ds.TravelCost(distance, gasFlow, gasPrice);
            Assert.AreEqual(wait, res);
        }
    }
}
