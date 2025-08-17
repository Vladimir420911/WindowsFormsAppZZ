using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace MyTest
{
    [TestClass]
    public class AppointmentTests
    {
        [TestMethod]
        public void Parse_ValidInput_ReturnsAppointment()
        {
            // Arrange
            var services = new Dictionary<string, Service>
            {
                {"Haircut", new Service("Haircut", 50, new List<string>{"Master1"})}
            };
            string line = "John;Haircut;Master1;15/01/2025";

            // Act
            var result = Appointment.Parse(line, services);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("John", result.Client);
            Assert.AreEqual("Haircut", result.ServiceName);
            Assert.AreEqual("Master1", result.Master);
            Assert.AreEqual(new DateTime(2025, 1, 15), result.Date);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void Parse_InvalidFormat_ThrowsFormatException()
        {
            // Arrange
            var services = new Dictionary<string, Service>();
            string line = "InvalidData";

            // Act
            Appointment.Parse(line, services);
        }
    }

    [TestClass]
    public class ServiceTests
    {
        [TestMethod]
        public void Parse_ValidInput_ReturnsService()
        {
            // Arrange
            string line = "Haircut;50.00;Master1,Master2";

            // Act
            var result = Service.Parse(line);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Haircut", result.Name);
            Assert.AreEqual(50.00m, result.Price);
            CollectionAssert.AreEqual(new List<string> { "Master1", "Master2" }, result.Masters);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void Parse_InvalidPrice_ThrowsFormatException()
        {
            // Arrange
            string line = "Haircut;invalid;Master1";

            // Act
            Service.Parse(line);
        }
    }

    [TestClass]
    public class SalonTests
    {
        private Salon _salon;
        private BindingList<Appointment> _appointments;

        [TestInitialize]
        public void Setup()
        {
            _salon = new Salon();
            _appointments = new BindingList<Appointment>
            {
                new Appointment("Client1",
                    new Service("Service1", 100, new List<string>{"Master1"}),
                    "Master1",
                    new DateTime(2025, 1, 15)),
                new Appointment("Client2",
                    new Service("Service2", 200, new List<string>{"Master2"}),
                    "Master2",
                    new DateTime(2025, 2, 20)),
                new Appointment("Client3",
                    new Service("Service1", 150, new List<string>{"Master1"}),
                    "Master1",
                    new DateTime(2025, 3, 10))
            };
        }

        [TestMethod]
        public void GenerateEmployeeReport_ValidPeriod_ReturnsCorrectReport()
        {
            // Arrange
            var startDate = new DateTime(2025, 1, 1);
            var endDate = new DateTime(2025, 3, 31);

            // Act
            var result = _salon.GenerateEmployeeReport(startDate, endDate, _appointments);

            // Assert
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual("Master1", result[0].Name);
            Assert.AreEqual(250m, result[0].Revenue);
            Assert.AreEqual("Master2", result[1].Name);
            Assert.AreEqual(200m, result[1].Revenue);
        }

        [TestMethod]
        public void GenerateRevenueReport_ValidPeriod_ReturnsCorrectRevenue()
        {
            // Arrange
            var startDate = new DateTime(2025, 1, 1);
            var endDate = new DateTime(2025, 3, 31);

            // Act
            var result = _salon.GenerateRevenueReport(startDate, endDate, _appointments);

            // Assert
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(450m, result[0].TotalRevenue);
        }

        [TestMethod]
        public void GenerateRevenueReport_NoAppointments_ReturnsZeroRevenue()
        {
            // Arrange
            var startDate = new DateTime(2025, 1, 1);
            var endDate = new DateTime(2025, 3, 31);
            var emptyAppointments = new BindingList<Appointment>();

            // Act
            var result = _salon.GenerateRevenueReport(startDate, endDate, emptyAppointments);

            // Assert
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(0m, result[0].TotalRevenue);
        }
    }

    [TestClass]
    public class EmployeeReportModelTests
    {
        [TestMethod]
        public void Constructor_SetsPropertiesCorrectly()
        {
            // Arrange
            string name = "Master1";
            decimal revenue = 1000m;

            // Act
            var model = new EmployeeReportModel(name, revenue);

            // Assert
            Assert.AreEqual(name, model.Name);
            Assert.AreEqual(revenue, model.Revenue);
        }
    }

    [TestClass]
    public class RevenueReportModelTests
    {
        [TestMethod]
        public void Constructor_SetsPropertiesCorrectly()
        {
            // Arrange
            var startDate = new DateTime(2025, 1, 1);
            var endDate = new DateTime(2025, 1, 31);
            decimal revenue = 5000m;

            // Act
            var model = new RevenueReportModel(startDate, endDate, revenue);

            // Assert
            Assert.AreEqual(startDate, model.StartDate);
            Assert.AreEqual(endDate, model.EndDate);
            Assert.AreEqual(revenue, model.TotalRevenue);
        }
    }
}