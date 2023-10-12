using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.NikolajchukVS.Sprint1.Task7.V18.Lib;

namespace Tyuiu.NikolajchukVS.Sprint1.Task7.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            {
                DataService ds = new DataService();
                double x = 3;
                double y = 5;
                double wait = 232.182;
                var res = Math.Round(ds.Calculate(x, y), 3);
                Assert.AreEqual(wait, res);

            }
        }
    }
}
