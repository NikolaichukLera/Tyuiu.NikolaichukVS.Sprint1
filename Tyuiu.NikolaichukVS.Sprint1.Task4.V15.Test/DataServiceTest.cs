using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.NikolaichukVS.Sprint1.Task4.V15.Lib;



namespace Tyuiu.NikolaichukVS.Sprint1.Task4.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double wait = 30.556;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);

        }
    }
}
