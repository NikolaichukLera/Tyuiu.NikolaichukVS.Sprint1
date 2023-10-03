using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.NikolaichukVS.Sprint1.Task2.V11.Lib;

namespace Tyuiu.NikolaichukVS.Sprint1.Task2.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 3;
            int y = 30;
            var res = (x, y);
            Assert.AreEqual(12600, res);
        }
    }
}
