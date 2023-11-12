using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.RachevES.Sprint4.Task0.V3.Lib;

namespace Tyuiu.RachevES.Sprint4.Task0.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] numsArray = { 8, 9, 4, 1, 2, 3, 4, 5, 6, 7 };

            int res = ds.GetMultOddArrEl(numsArray);

            int numsWaitArray = 1536;

            Assert.AreEqual(numsWaitArray, res);
        }
    }
}
