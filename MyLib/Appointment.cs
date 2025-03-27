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
        public string Service { get; set; }
        public decimal Price { get; set; }
        public string Master { get; set; }
        public DateTime Date { get; set; }

        public Appointment(string client, string service, decimal price, string master, DateTime date)
        {
            Client = client;
            Service = service;
            Price = price;
            Master = master;
            Date = date;
        }
    }
}
