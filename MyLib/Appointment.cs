using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MyLib
{
    public class Appointment
    {
        public string Client { get; set; }
        [Browsable(false)]
        public Service Service { get; set; }
        public string ServiceName { get { return Service.Name; } }
        public string Master { get; set; }
        public DateTime Date { get; set; }

        public Appointment(string client, Service service, string master, DateTime date)
        {
            Client = client;
            Service = service;
            Master = master;
            Date = date;
        }

        public static Appointment Parse(string line, Dictionary<string, Service> services)
        {
            string[] lines = line.Split(';');
            if (lines.Length != 4)
            {
                throw new FormatException("Неправильный формат строки услуги");
            }
            try
            {
                string clientName = lines[0];
                string serviceName = lines[1];
                string master = lines[2];
                DateTime date = DateTime.ParseExact(lines[3], "d/MM/yyyy", null);

                if(services.ContainsKey(serviceName))
                {
                    Service service = services[serviceName];
                    Appointment newAppointment = new Appointment(clientName, service, master, date);
                    return newAppointment;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ошибка при чтении файла: {ex}");
            }

            return null;
        }
    }
}
