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
    public partial class Form1: Form
    {
        List<Appointment> appointments = new List<Appointment>

        {
            new Appointment("Олег", "ноготки", 500, "Мастер1", new DateTime(2025, 01, 15)),
            new Appointment("Олег2", "пушка калатушка", 750, "Мастер2", new DateTime(2025, 02, 15)),
            new Appointment("Кельвин", "бомба петарррррда", 450, "Мастер3", new DateTime(2025, 03, 15))
        };
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = appointments;
        }

        public string GenerateRevenueReport(DateTime startDate, DateTime endDate)
        {
            var revenue = appointments
                .Where(a => a.Date >= startDate && a.Date <= endDate)
                .Sum(a => a.Price);
            return textBox1.Text = $"Выручка за период с {startDate:d} по {endDate:d}: {revenue:C}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenerateRevenueReport(dateTimePicker1.Value, dateTimePicker2.Value);

        }
    }


}
