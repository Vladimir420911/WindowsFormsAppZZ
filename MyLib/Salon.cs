using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class Salon
    {
        public string GenerateRevenueReport(DateTime startDate, DateTime endDate, List<Appointment> appointments)
        {
            var revenue = appointments
                .Where(a => a.Date >= startDate && a.Date <= endDate)
                .Sum(a => a.Price);
            string output = $"Выручка за период с {startDate:d} по {endDate:d}: {revenue:C}";
            return output;
        }
    }
}
