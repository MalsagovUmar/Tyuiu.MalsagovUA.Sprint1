using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MalsagovUA.Sprint1.Task1.V1.Lib;
namespace Tyuiu.MalsagovUA.Sprint1.Task1.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 1.0;
            double x = 9.0;
            double y = 3.0;
            var res = ds.Calculate(a, x, y);
            Assert.AreEqual(7, res);
        }
    }
}
