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
        /*
        public BindingList<string> masters = new BindingList<string>
        {
            "Мастер1","Мастер2","Мастер3"
        };
        public BindingList<Service> services = new BindingList<Service>
        {
            new Service("ноготки", 499.99, masters)
        };
        public BindingList<Appointment> appointments = new BindingList<Appointment>
        {
            new Appointment("Олег", "ноготки", 500, "Мастер1", new DateTime(2025, 01, 15)),
            new Appointment("Олег2", "пушка калатушка", 750, "Мастер2", new DateTime(2025, 02, 15)),
            new Appointment("Кельвин", "бомба петарррррда", 450, "Мастер3", new DateTime(2025, 03, 15))
        };
        */

        public void PopulateLists()
        {
            clients = new BindingList<string>
            {
                "Олег", "Олег2", "Келвин"
            };
            masters = new BindingList<string>
            {
                "Мастер1","Мастер2","Мастер3"
            };
            services = new BindingList<Service>
            {
                new Service("ноготки", 499.99, masters),
                new Service("пушка калатушка", 749.99, masters),
                new Service("бомба петарррррда", 449.99, masters)
            };
            appointments = new BindingList<Appointment>
            {
                 new Appointment(clients[0], services[0].Name, services[0].Price, "Мастер1", new DateTime(2025, 01, 15)),
                 new Appointment(clients[1], services[1].Name, services[1].Price, "Мастер2", new DateTime(2025, 02, 15)),
                 new Appointment(clients[2], services[2].Name, services[2].Price, "Мастер3", new DateTime(2025, 03, 15))
            };
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
