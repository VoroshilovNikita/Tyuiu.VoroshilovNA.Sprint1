using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.VoroshilovNA.Sprint1.Task7.V3.Lib;

namespace Tyuiu.VoroshilovNA.Sprint1.Task7.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 1;
            double wait = 2.568 ;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
