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
    public partial class AddAppointmentF : Form
    {
        BindingList<string> mastersBind;
        BindingList<Service> servicesBind;
        public AddAppointmentF(BindingList<string> mastersB, BindingList<Service> servicesB)
        {
            InitializeComponent();
            mastersBind = mastersB;
            servicesBind = servicesB;

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
                                              ReturnService(),
                                              MasterComboBox.Text,
                                              dateTimePicker1.Value.Date);

            //appointmentsBind.Add(appointment);
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private Service ReturnService()
        {
            return ServiceComboBox.SelectedItem as Service;
        }
    }
}
