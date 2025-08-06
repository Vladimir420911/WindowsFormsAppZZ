using MyLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AppointmentsForm : Form
    {
        Salon salon = new Salon();
        BindingList<Appointment> appointments;
        BindingList<Service> services;
        public AppointmentsForm(BindingList<Appointment> appointmentsBind, BindingList<Service> servicesBind)
        {
            InitializeComponent();
            appointments = appointmentsBind;
            services = servicesBind;
            AppoinmentDataTable.DataSource = appointments;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddAppointmentForm addForm = new AddAppointmentForm(services, appointments);
            addForm.Show();
        }
    }
}
