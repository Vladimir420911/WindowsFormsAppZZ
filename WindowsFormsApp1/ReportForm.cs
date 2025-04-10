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
            ReportTable.DataSource = a;
        }

        private void EmployeeReportButton_Click(object sender, EventArgs e)
        {
            ReportTable.DataSource = salon.GenerateEmployeeReport(DateTimeStart.Value.Date, DateTimeEnd.Value.Date, a);
        }

        private void RevenueReportButton_Click(object sender, EventArgs e)
        {
            ReportTable.DataSource = salon.GenerateRevenueReport(DateTimeStart.Value.Date, DateTimeEnd.Value.Date, a);
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ReportTable.DataSource = a;
        }
    }
}
