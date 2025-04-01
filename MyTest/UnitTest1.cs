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
        Salon salon = new Salon();
        [TestMethod]
        public void TestGenerateRevenueReport()
        {
            salon.PopulateLists();
            DateTime startDate = new DateTime(2025, 02, 14);
            DateTime endDate = new DateTime(2025, 03, 16);
            string expOutput = $"Выручка за период с {startDate:d} по {endDate:d}: {1199.98:C}";

            string result = salon.GenerateRevenueReport(startDate, endDate);

            Assert.AreEqual(expOutput, result);
        }

        [TestMethod]
        public void TestGenerateEmployeeReport()
        {
            salon.PopulateLists();
            DateTime startDate = new DateTime(2025, 01, 01);
            DateTime endDate = new DateTime(2025, 04, 01);
            string expOutput = $"Отчет по сотрудникам за период с {startDate:d} по {endDate:d}:\n" +
                               $"Гнарп: {749.99m:C}\n" +
                               $"Боб: {499.99m:C}\n" +
                               $"Габриель: {449.99m:C}\n";

            string result = salon.GenerateEmployeeReport(startDate, endDate);
            Assert.AreEqual(expOutput, result);
        }
    }
}
