using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class Service
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        [Browsable(false)]
        public List<string> Masters { get; set; }
        public string Master { get { return $"{string.Join(",", Masters)}"; } }



        public Service(string name, decimal price, List<string> masters)
        {
            Name = name;
            Price = price;
            Masters = masters;
        }

        public static Service Parse(string line)
        {
            string[] parts = line.Split(';');
            if (parts.Length != 3) throw new FormatException("Неправильный формат строки услуги");

            string[] masters = parts[2].Split(',');
            if(masters.Length < 1) throw new FormatException("Неправильный формат строки услуги");

            return new Service(parts[0], decimal.Parse(parts[1], CultureInfo.InvariantCulture), masters.ToList());
        }
    }
}
