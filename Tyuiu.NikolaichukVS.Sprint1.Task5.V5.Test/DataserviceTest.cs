using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.NikolaichukVS.Sprint1.Task5.V5.Lib;

namespace Tyuiu.NikolaichukVS.Sprint1.Task5.V5.Test
{
    [TestClass]
    public class DataserviceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double x = 32.597;
            DataService ds = new DataService();
            double res = ds.Calculate(x);

            int result = Convert.ToInt32(res);

            double d = 5;
            Assert.AreEqual(d, res);


           



        }
    }
}
