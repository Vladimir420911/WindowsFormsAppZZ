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
        List<Appointment> appointments = new List<Appointment>
        {
            new Appointment("Олег", "ноготки", 500, "Мастер1", new DateTime(2025, 01, 15)),
            new Appointment("Олег2", "пушка калатушка", 750, "Мастер2", new DateTime(2025, 02, 15)),
            new Appointment("Кельвин", "бомба петарррррда", 450, "Мастер3", new DateTime(2025, 03, 15))
        };
        [TestMethod]
        public void TestGenerateRevenueReport()
        {
            DateTime startDate = new DateTime(2025, 02, 14);
            DateTime endDate = new DateTime(2025, 03, 16);
            string expOutput = $"Выручка за период с {startDate:d} по {endDate:d}: {1200:C}";

            string result = GenerateRevenueReport(startDate, endDate);

            Assert.AreEqual(expOutput, result);
        }

        public string GenerateRevenueReport(DateTime startDate, DateTime endDate)
        {
            var revenue = appointments
                .Where(a => a.Date >= startDate && a.Date <= endDate)
                .Sum(a => a.Price);
            return $"Выручка за период с {startDate:d} по {endDate:d}: {revenue:C}";
        }


    }
}
