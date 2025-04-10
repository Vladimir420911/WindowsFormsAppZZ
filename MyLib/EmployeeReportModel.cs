using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class EmployeeReportModel
    {
        public string Name { get; set; }
        public decimal Revenue { get; set; }

        public EmployeeReportModel(string n, decimal p) 
        {
            Name = n;
            Revenue = p;
        }
    }
}
