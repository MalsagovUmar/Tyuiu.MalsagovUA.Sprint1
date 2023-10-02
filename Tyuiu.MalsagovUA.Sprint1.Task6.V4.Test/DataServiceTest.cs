using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Tyuiu.MalsagovUA.Sprint1.Task6.V4.Lib;
namespace Tyuiu.MalsagovUA.Sprint1.Task6.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            DataService ds = new DataService();
            string strTest = "Давно пора нам поехать по заданному министром маршруту, огибая странные горы";
            string res = ds.CheckDoubleN(strTest);
            string wait = "заданному, странные";
            Assert.AreEqual(wait, res);
        }
    }
}
