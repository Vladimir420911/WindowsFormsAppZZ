using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class Appointment
    {
        public string Client { get; set; }
        public Service Service { get; set; }
        public string Master { get; set; }
        public DateTime Date { get; set; }

        public Appointment(string client, Service service, string master, DateTime date)
        {
            Client = client;
            Service = service;
            Master = master;
            Date = date;
        }
    }
}
