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
                 new Appointment("Олег", services[0].Name, services[0].Price, masters[0], new DateTime(2025, 01, 15)),
                 new Appointment("Олег2", services[1].Name, services[1].Price, masters[1], new DateTime(2025, 02, 15)),
                 new Appointment("Келвин", services[2].Name, services[2].Price, masters[2], new DateTime(2025, 03, 15))
            };
        }

        public string GenerateEmployeeReport(DateTime startDate, DateTime endDate)
        {
            var employeeRevenue = appointments
                 .Where(a => a.Date >= startDate && a.Date <= endDate && a.Date <= DateTime.Today)
                 .GroupBy(a => a.Master)
                 .Select(g => new { Master = g.Key, Revenue = g.Sum(a => a.Price) })
                 .OrderByDescending(e => e.Revenue)
                 .ToList();

            var report = $"Отчет по сотрудникам за период с {startDate:d} по {endDate:d}:\n";
            foreach (var employee in employeeRevenue)
            {
                report += $"{employee.Master}: {employee.Revenue:C}\n";
            }
            return report;
        }

        public string GenerateRevenueReport(DateTime startDate, DateTime endDate)
        {
            var revenue = appointments
                .Where(a => a.Date >= startDate && a.Date <= endDate && a.Date <= DateTime.Today)
                .Sum(a => a.Price);
            
            return $"Выручка за период с {startDate:d} по {endDate:d}: {revenue:C}";
        }
    }
}
