using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class Service
    {

        public string Name { get; set; }
        public decimal Price { get; set; }
        public BindingList<string> Masters { get; set; }

        public Service(string name, decimal price, BindingList<string> masters)
        {
            Name = name;
            Price = price;
            Masters = masters;
        }
    }
}
