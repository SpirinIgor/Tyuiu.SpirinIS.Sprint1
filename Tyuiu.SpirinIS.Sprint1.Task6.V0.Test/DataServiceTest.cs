using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SpirinIS.Sprint1.Task6.V0.Lib;

namespace Tyuiu.SpirinIS.Sprint1.Task6.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "1 * 2 * 3";
            DataService ds = new DataService();
            string res = ds.WorkWithText(strTest);
            string wait = "123";
            Assert.AreEqual(wait, res);

        }
    }
}
