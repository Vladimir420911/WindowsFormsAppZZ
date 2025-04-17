using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class Salon
    {
        public BindingList<string> clients;
        public BindingList<string> masters;
        public BindingList<Service> services;
        public BindingList<Appointment> appointments;
        public void PopulateLists()
        {
            
            clients = new BindingList<string>
            {
                "Олег", "Олег2", "Келвин"
            };
            
            masters = new BindingList<string>
            {
                "Боб","Гнарп","Габриель"
            };
            services = new BindingList<Service>
            {
                new Service("ноготки", 499.99m, masters),
                new Service("пушка калатушка", 749.99m, masters),
                new Service("бомба петарррррда", 449.99m, masters)
            };
            appointments = new BindingList<Appointment>
            {
                 new Appointment(clients[0], services[0].Name, services[0].Price, masters[0], new DateTime(2025, 01, 15)),
                 new Appointment(clients[1], services[1].Name, services[1].Price, masters[1], new DateTime(2025, 02, 15)),
                 new Appointment(clients[2], services[2].Name, services[2].Price, masters[2], new DateTime(2025, 03, 15))
            };
        }

        public List<EmployeeReportModel> GenerateEmployeeReport(DateTime startDate, DateTime endDate, BindingList<Appointment> appointments)
        {
            var employeeRevenue = appointments
                 .Where(a => a.Date >= startDate && a.Date <= endDate && a.Date <= DateTime.Today)
                 .GroupBy(a => a.Master)
                 .Select(g => new { Master = g.Key, Revenue = g.Sum(a => a.Price) })
                 .OrderByDescending(e => e.Revenue)
                 .ToList();

            List<EmployeeReportModel> report = new List<EmployeeReportModel>();
            foreach (var emp in employeeRevenue)
            {
                report.Add(new EmployeeReportModel(emp.Master, emp.Revenue));
            }
            return report;
        }

        public List<RevenueReportModel> GenerateRevenueReport(DateTime startDate, DateTime endDate, BindingList<Appointment> appointments)
        {
            var revenue = appointments
                .Where(a => a.Date >= startDate && a.Date <= endDate && a.Date <= DateTime.Today)
                .Sum(a => a.Price);

            List<RevenueReportModel> report = new List<RevenueReportModel>();
            report.Add(new RevenueReportModel(startDate, endDate, revenue));

            return report;
        }
    }
}
