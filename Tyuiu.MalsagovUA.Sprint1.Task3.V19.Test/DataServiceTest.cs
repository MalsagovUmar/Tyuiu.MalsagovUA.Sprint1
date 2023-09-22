using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MalsagovUA.Sprint1.Task3.V19.Lib;
namespace Tyuiu.MalsagovUA.Sprint1.Task3.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x1 = 1;
            double y1 = 1;
            double x2 = 4;
            double y2 = 4;
            var res = ds.ElephCanMove(x1, y1, x2, y2);
            Assert.AreEqual(res, true);
        }
    }
}
