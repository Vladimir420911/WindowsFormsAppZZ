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
        string servicesFilename = "services.txt";
        public BindingList<Service> services;
        public Form1()
        {
            InitializeComponent();
            salon.LoadServicesFromFile(servicesFilename);

            services = salon.services;
            dataGridView1.DataSource = services;
        }
        /*
        private void AddAppointment_Click(object sender, EventArgs e)
        {
            var appointentForm = new AppointmentForm(salon.masters, salon.services);
            appointentForm.Show();
        }

        private void отчётностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var reportForm = new ReportForm();
            reportForm.Show();
        }
        */
        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Вы нажали на Гнарпа", "Поздравляю!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void записиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppointmentsForm appointmentsForm = new AppointmentsForm();

            appointmentsForm.Left = this.Left;
            appointmentsForm.Top = this.Top;
            appointmentsForm.Show();

            this.Hide();
        }
    }


}
