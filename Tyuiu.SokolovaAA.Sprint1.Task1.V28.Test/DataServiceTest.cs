﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SokolovaAA.Sprint1.Task1.V28.Lib;
namespace Tyuiu.SokolovaAA.Sprint1.Task1.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            double x = 1;
            var res = ds.Calculate(x);
            Assert.AreEqual(1, res);
        }
    }
}
