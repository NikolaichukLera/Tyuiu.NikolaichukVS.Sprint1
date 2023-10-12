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
            DataService ds = new DataService();
            double x = 32.597;
            double y = 10;
            var res = DataService.Calc(x, y);
            
            Assert.AreEqual(d, res);


           



        }
    }
}
