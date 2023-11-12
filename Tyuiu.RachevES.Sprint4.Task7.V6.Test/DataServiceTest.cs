using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.RachevES.Sprint4.Task7.V6.Lib;

namespace Tyuiu.RachevES.Sprint4.Task7.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int n = 3;

            int m = 4;

            int[,] mtrx = new int[n, m];

            string str = "458963214789";

            DataService ds = new DataService();

            int res = ds.Calculate(n, m, str);

            int wait = 6;

            Assert.AreEqual(wait, res);
        }
    }
}
