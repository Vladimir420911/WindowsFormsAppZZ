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
    public partial class AppointmentForm : Form
    {
        BindingList<string> mastersBind;
        BindingList<Service> servicesBind;
        BindingList<Appointment> appointmentsBind;
        public AppointmentForm(BindingList<string> mastersB, BindingList<Service> servicesB, BindingList<Appointment> appointmentsB)
        {
            InitializeComponent();
            mastersBind = mastersB;
            servicesBind = servicesB;
            appointmentsBind = appointmentsB;

            List<string> serviceName = new List<string>();
            for (int i = 0; i < servicesBind.Count(); i++)
            {
                serviceName.Add(servicesBind[i].Name);
            }

            ServiceComboBox.DataSource = serviceName;
            MasterComboBox.DataSource = mastersBind;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var appointment = new Appointment(NameTextBox.Text, 
                                              ServiceComboBox.Text,
                                              PriceNumericUpDown.Value,
                                              MasterComboBox.Text,
                                              dateTimePicker1.Value.Date);

            appointmentsBind.Add(appointment);
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ServiceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PriceNumericUpDown.Value = servicesBind[ServiceComboBox.SelectedIndex].Price;
            //MasterComboBox.DataSource = mastersBind[ServiceComboBox.SelectedIndex].
        }
    }
}
