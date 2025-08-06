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
    public partial class MainForm: Form
    {
        Salon salon = new Salon();
        string servicesFilename = "services.txt";
        public List<Service> services;
        public MainForm()
        {
            InitializeComponent();
            salon.LoadServicesFromFile(servicesFilename);
            services = salon.services.Values.ToList();

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

            string appointmentsFilename = "appointments.txt";
            salon.LoadAppointmentsFromFile(appointmentsFilename);
            BindingList<Service> servicesBind = new BindingList<Service>(services);
            AppointmentsForm appointmentsForm = new AppointmentsForm(salon.appointments, servicesBind);

            appointmentsForm.Show();
        }
    }


}
