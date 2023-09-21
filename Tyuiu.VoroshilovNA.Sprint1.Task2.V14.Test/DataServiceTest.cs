using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.VoroshilovNA.Sprint1.Task2.V14.Lib;

namespace Tyuiu.VoroshilovNA.Sprint1.Task2.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 2;
            var res = ds.ConvertKelvinToCelsius(x);
            Assert.AreEqual(-271, res);
        }
    }
}
