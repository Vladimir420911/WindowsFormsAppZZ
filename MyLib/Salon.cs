using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class Salon
    {
        public List<Appointment> appointments = new List<Appointment>
        {
            new Appointment("Олег", "ноготки", 500, "Мастер1", new DateTime(2025, 01, 15)),
            new Appointment("Олег2", "пушка калатушка", 750, "Мастер2", new DateTime(2025, 02, 15)),
            new Appointment("Кельвин", "бомба петарррррда", 450, "Мастер3", new DateTime(2025, 03, 15))
        };
        public string GenerateRevenueReport(DateTime startDate, DateTime endDate)
        {
            var revenue = appointments
                .Where(a => a.Date >= startDate && a.Date <= endDate)
                .Sum(a => a.Price);
            
            return $"Выручка за период с {startDate:d} по {endDate:d}: {revenue:C}";
        }
    }
}
