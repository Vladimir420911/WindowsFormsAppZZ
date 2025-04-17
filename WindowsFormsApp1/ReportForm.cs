using MyLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ReportForm: Form
    {
        Salon salon = new Salon();
        BindingList<Appointment> a;
        public ReportForm(BindingList<Appointment> _a)
        {
            InitializeComponent();
            a = _a;
            ReportTable.DataSource = null;
        }

        private void EmployeeReportButton_Click(object sender, EventArgs e)
        {
            var employeeReport = salon.GenerateEmployeeReport(DateTimeStart.Value.Date, DateTimeEnd.Value.Date, a);
            if (employeeReport != null && employeeReport.Any())
            {
                ReportTable.DataSource = employeeReport;
            }
            else
            {
                MessageBox.Show("Отчет пуст", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void RevenueReportButton_Click(object sender, EventArgs e)
        {
            var revenueReport = salon.GenerateRevenueReport(DateTimeStart.Value.Date, DateTimeEnd.Value.Date, a);
            if (revenueReport.Any(rev => rev.TotalRevenue != 0))
            {
                ReportTable.DataSource = revenueReport;
            }
            else
            {
                MessageBox.Show("Отчет пуст", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ReportTable.DataSource = null;
        }
    }
}
