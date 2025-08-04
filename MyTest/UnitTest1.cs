using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLib;

namespace MyTest
{/*
    [TestClass]
    public class UnitTest1
    {
        Salon salon = new Salon();
        [TestMethod]
        public void TestGenerateRevenueReport_ValidData()
        {
            salon.PopulateLists();
            DateTime startDate = new DateTime(2025, 01, 10);
            DateTime endDate = new DateTime(2025, 03, 20);

            var report = salon.GenerateRevenueReport(startDate, endDate, salon.appointments);

            Assert.AreEqual(1699.97m, report[0].TotalRevenue);
        }

        [TestMethod]
        public void TestGenereateRevenueReport_EmptyData()
        {
            salon.PopulateLists();
            DateTime startDate = new DateTime(2025, 03, 20);
            DateTime endDate = new DateTime(2025, 04, 05);

            var report = salon.GenerateRevenueReport(startDate, endDate, salon.appointments);

            Assert.AreEqual(0, report[0].TotalRevenue);
        }

        [TestMethod]
        public void TestGenereateRevenueReport_SameDataRange()
        {
            salon.PopulateLists();
            DateTime startDate = new DateTime(2025, 01, 15);
            DateTime endDate = new DateTime(2025, 02, 15);

            var report = salon.GenerateRevenueReport(startDate, endDate, salon.appointments);

            Assert.AreEqual(1249.98m, report[0].TotalRevenue);
        }
    }
    */
}