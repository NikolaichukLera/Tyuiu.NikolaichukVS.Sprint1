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
            int k = 7200;
            
            DataService ds = new DataService();
            
            double res = ds.SecondsToHours(k);

            int result = Convert.ToInt32(res);

            int h = 2;

            Assert.AreEqual(h, result);

                
           



        }
    }
}
