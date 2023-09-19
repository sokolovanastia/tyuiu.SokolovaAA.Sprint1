using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SokolovaAA.Sprint1.Task0.V0.Lib;
namespace Tyuiu.SokolovaAA.Sprint1.Task0.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalc()
        {
            int FirstNum = 1;
            int SecondNum = 4;

            int res = DataService.Calc(FirstNum, SecondNum);

            Assert.AreEqual(15, res);
        }   
    }
}
