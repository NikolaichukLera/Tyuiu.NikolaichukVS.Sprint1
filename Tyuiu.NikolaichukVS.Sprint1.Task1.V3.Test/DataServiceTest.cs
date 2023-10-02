using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.NikolaichukVS.Sprint1.Task1.V3.Lib;

namespace Tyuiu.NikolaichukVS.Sprint1.Task1.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = -13;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(2, res);
        }
    }
}
