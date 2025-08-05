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
        public Dictionary<string, Service> services = new Dictionary<string, Service>();
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
                        Service service = Service.Parse(line);
                        services.Add(service.Name, service);
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

        public void LoadAppointmentsFromFile(string filename)
        {
            if(!File.Exists(filename))
            {
                MessageBox.Show($"Файл {filename} не найден. Убедитесь, что файл существует и указан правильный путь.");
                return;
            }
            try
            {
                string[] lines = File.ReadAllLines(filename);
                appointments.Clear();
                foreach(var line in lines)
                {
                    try
                    {
                        Appointment appoinment = Appointment.Parse(line, services);
                        if(appoinment != null)
                        {
                            appointments.Add(appoinment);
                        }
                    }
                    catch(FormatException e)
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

        public void PopulateDataGrid(BindingList<Appointment> appointments, DataGridView dataGridView)
        {
            dataGridView.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn clientColumn = new DataGridViewTextBoxColumn();
            clientColumn.DataPropertyName = "Client";
            clientColumn.HeaderText = "Client";

            DataGridViewTextBoxColumn serviceNameColumn = new DataGridViewTextBoxColumn();
            serviceNameColumn.DataPropertyName = "ServiceName";
            serviceNameColumn.HeaderText = "ServiceName";

            DataGridViewTextBoxColumn masterColumn = new DataGridViewTextBoxColumn();
            masterColumn.DataPropertyName = "Master";
            masterColumn.HeaderText = "Master";

            DataGridViewTextBoxColumn dateColumn = new DataGridViewTextBoxColumn();
            dateColumn.DataPropertyName = "Date";
            dateColumn.HeaderText = "Date";
            dateColumn.DefaultCellStyle.Format = "d/MM/yyyy";

            dataGridView.Columns.Clear();
            dataGridView.Columns.Add(clientColumn);
            dataGridView.Columns.Add(serviceNameColumn);
            dataGridView.Columns.Add(masterColumn);
            dataGridView.Columns.Add(dateColumn);

            dataGridView.DataSource = null;
            dataGridView.DataSource = appointments;
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
