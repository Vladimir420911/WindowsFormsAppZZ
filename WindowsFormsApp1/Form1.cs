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
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1: Form
    {
        Salon salon = new Salon();
        public Form1()
        {
            InitializeComponent();
            salon.PopulateLists();
            var appointments = salon.appointments;
            dataGridView1.DataSource = appointments;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(salon.GenerateRevenueReport(dateTimePicker1.Value, dateTimePicker2.Value), "Отчет по доходам", MessageBoxButtons.OK, MessageBoxIcon.Information);
            File.WriteAllText("RevenueReport.txt", salon.GenerateRevenueReport(dateTimePicker1.Value, dateTimePicker2.Value));
        }

        private void AddAppointment_Click(object sender, EventArgs e)
        {
            var appointentForm = new AppointmentForm(salon.masters, salon.services, salon.appointments);
            appointentForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(salon.GenerateEmployeeReport(dateTimePicker1.Value, dateTimePicker2.Value), "Рейтинг сотрудников", MessageBoxButtons.OK, MessageBoxIcon.Information);
            File.WriteAllText("EmployeeReport.txt", salon.GenerateEmployeeReport(dateTimePicker1.Value, dateTimePicker2.Value));
        }
    }


}
