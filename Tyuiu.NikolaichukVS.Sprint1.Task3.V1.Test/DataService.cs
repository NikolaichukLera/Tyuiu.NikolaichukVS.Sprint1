using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.NikolaichukVS.Sprint1.Task3.V1.Lib;

namespace Tyuiu.NikolaichukVS.Sprint1.Task3.V1.Test
{
    [TestClass]
    public class DataService
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double r = 2;
            double h = 3;
            double V = 37.699;
            var res = ds.CylinderVolume(r, h); 
            Assert.AreEqual(V, res);



        }
    }
}
