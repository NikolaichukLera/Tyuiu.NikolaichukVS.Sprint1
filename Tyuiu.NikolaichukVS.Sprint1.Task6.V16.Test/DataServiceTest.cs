using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.NikolaichukVS.Sprint1.Task6.V16.Lib;

namespace Tyuiu.NikolaichukVS.Sprint1.Task6.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "один два три";
            DataService ds = new DataService();
            string res = ds.DeleteLastLetter(strTest);
            string wait = "оди дв тр";
            Assert.AreEqual(wait, res);
        }
    }
}
