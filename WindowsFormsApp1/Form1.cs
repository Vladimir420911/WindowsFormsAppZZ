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
        public BindingList<Appointment> appointments;
        public Form1()
        {
            InitializeComponent();
            salon.PopulateLists();
            appointments = salon.appointments;
            dataGridView1.DataSource = appointments;
        }

        private void AddAppointment_Click(object sender, EventArgs e)
        {
            var appointentForm = new AppointmentForm(salon.masters, salon.services, appointments);
            appointentForm.Show();
        }

        private void отчётностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var reportForm = new ReportForm(appointments);
            reportForm.Show();
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Вы нажали на гнарпа", "Поздравляю!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }


}
