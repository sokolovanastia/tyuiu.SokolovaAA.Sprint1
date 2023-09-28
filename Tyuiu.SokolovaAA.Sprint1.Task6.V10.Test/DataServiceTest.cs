using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SokolovaAA.Sprint1.Task6.V10.Lib;
namespace Tyuiu.SokolovaAA.Sprint1.Task6.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            DataService ds = new DataService();
            string inputText = "Сегодня хорошая погода";
            string wait = "Сегдня хоршая погода";
            string res = ds.DeleteMiddleLetter(inputText);

            Assert.AreEqual(wait, res);
        }
    }
}
