using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace MyLib
{
    public class Salon
    {
        public BindingList<string> clients = new BindingList<string>();
        public BindingList<Service> services = new BindingList<Service>();
        public BindingList<Appointment> appointments = new BindingList<Appointment>();

        public void LoadServicesFromFile(string filename)
        {
            if (!File.Exists(filename))
            {
                MessageBox.Show($"Файл {filename} не найден. Убедитесь, что файл существует и указан правильный путь.");
                return;
            }
            try
            {
                var lines = File.ReadAllLines(filename);
                services.Clear();
                foreach (var line in lines)
                {
                    try
                    {
                        services.Add(Service.Parse(line));
                    }
                    catch (FormatException e)
                    {
                        MessageBox.Show($"Ошибка при чтении строки: '{line}'. Ошибка:{e.Message}");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при чтении файла {filename}: {ex.Message}");
            }
        }

        public List<EmployeeReportModel> GenerateEmployeeReport(DateTime startDate, DateTime endDate, BindingList<Appointment> appointments)
        {
            var employeeRevenue = appointments
                 .Where(a => a.Date >= startDate && a.Date <= endDate && a.Date <= DateTime.Today)
                 .GroupBy(a => a.Master)
                 .Select(g => new { Master = g.Key, Revenue = g.Sum(a => a.Service.Price) })
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
                .Sum(a => a.Service.Price);

            List<RevenueReportModel> report = new List<RevenueReportModel>();
            report.Add(new RevenueReportModel(startDate, endDate, revenue));

            return report;
        }
    }
}
