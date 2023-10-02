using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.VoroshilovNA.Sprint1.Task6.V8.Lib;

namespace Tyuiu.VoroshilovNA.Sprint1.Task6.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "собака";
            DataService ds = new DataService();
            string res = ds.MoveLetterToEnd(strTest);
            string wait = "обакас";
            Assert.AreEqual(wait, res);
        }
    }
}
