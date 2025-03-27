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
            var appointments = salon.appointments;
            dataGridView1.DataSource = appointments;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = salon.GenerateRevenueReport(dateTimePicker1.Value, dateTimePicker2.Value);
            File.WriteAllText("RevenueReport.txt", textBox1.Text);
        }
    }


}
