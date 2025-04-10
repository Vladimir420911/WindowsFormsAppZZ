using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class RevenueReportModel
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal TotalRevenue { get; set; }

        public RevenueReportModel(DateTime sd, DateTime ed, decimal tr) 
        {
            StartDate = sd;
            EndDate = ed;
            TotalRevenue = tr;
        }
    }
}
