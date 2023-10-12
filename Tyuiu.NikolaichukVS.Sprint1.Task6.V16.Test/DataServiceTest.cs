using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.NikolaichukVS.Sprint1.Task6.V16.Lib;

namespace Tyuiu.NikolaichukVS.Sprint1.Task6.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            string strTest = "Ну нужно!";
            DataService ds = new DataService();
            string res = ds.CheckSpecSymbols(strTest);
            string wait = "!";
            Assert.AreEqual(wait, res);

        }
    }
}
