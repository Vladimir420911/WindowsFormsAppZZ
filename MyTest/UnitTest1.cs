using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLib;

namespace MyTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGenerateRevenueReport()
        {
            Salon salon = new Salon();
            DateTime startDate = new DateTime(2025, 02, 14);
            DateTime endDate = new DateTime(2025, 03, 16);
            string expOutput = $"Выручка за период с {startDate:d} по {endDate:d}: {1200:C}";

            string result = salon.GenerateRevenueReport(startDate, endDate);

            Assert.AreEqual(expOutput, result);
        }
    }
}
