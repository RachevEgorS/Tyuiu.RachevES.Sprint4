using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.RachevES.Sprint4.Task2.V13.Lib;
namespace Tyuiu.RachevES.Sprint4.Task2.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate()
        {
            DataService ds = new DataService();

            int[] numArray = { 2, 10, 8, 5, 4, 3, 2, 1, 6, 3, 4, 8, 7 };

            int res = ds.Calculate(numArray);

            Assert.AreEqual(24576, res);

        }
    }
}
