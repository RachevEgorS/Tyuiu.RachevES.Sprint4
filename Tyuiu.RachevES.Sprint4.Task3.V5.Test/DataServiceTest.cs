using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.RachevES.Sprint4.Task3.V5.Lib;

namespace Tyuiu.RachevES.Sprint4.Task3.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()

        {
            DataService ds = new DataService();

            int[,] Array = new int[5, 5] { { 3, 4, 8, 6, 3 }, { 9, 9, 3, 6, 9 },

                { 5, 6, 7, 2, 3 }, { 3, 6, 2, 3, 8 }, { 5, 7, 2, 6, 4 } };

            int res = ds.Calculate(Array);

            int wait = 25;

            Assert.AreEqual(wait, res);
        }
    }
}
