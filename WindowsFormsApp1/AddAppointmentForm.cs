using MyLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AddAppointmentForm : Form
    {
        Dictionary<string, List<string>> listsOfMasters;
        Salon salon = new Salon();
        BindingList<Service> services;
        BindingList<Appointment> appointments;
        public AddAppointmentForm(BindingList<Service> servicesBind, BindingList<Appointment> appointmentsBind)
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";

            services = servicesBind;
            appointments = appointmentsBind;

            listsOfMasters = salon.LoadMastersToDict(services);


            //string masters = listsOfMasters.Values.ToString();
            //NameTextBox.Text = masters;
            //mastersBind = mastersB;
            ////servicesBind = servicesB;

            List<string> serviceName = new List<string>();
            for (int i = 0; i < services.Count(); i++)
            {
                serviceName.Add(services[i].Name);
            }

            ServiceComboBox.DataSource = serviceName;
            //MasterComboBox.DataSource = mastersBind;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string filename = "appointments.txt";
            string clientName = NameTextBox.Text;
            Service service = GetService();
            string master = MasterComboBox.Text;
            string date = dateTimePicker1.Text;
            var appointment = new Appointment(clientName,
                                              service,
                                              master,
                                              Convert.ToDateTime(date));

            appointments.Add(appointment);
            salon.WriteAppointmentToFile(filename, clientName, service, master, date);
            Close();
        }

        private Service GetService()
        {
            string serviceName = ServiceComboBox.Text;
            foreach(var service in services)
            {
                if (serviceName == service.Name)
                {
                    return service;
                }
            }

            return null;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ServiceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string serviceName = ServiceComboBox.Text;
            List<string> masters = listsOfMasters[serviceName];

            MasterComboBox.DataSource = masters;
        }
    }
}
