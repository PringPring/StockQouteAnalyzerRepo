using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockQouteAnalyzer.ClassLibrary
{
   public class StockQoute
    {
        public DateTime Date { get; set; }
        public decimal Open { get; set; }
        public decimal High { get; set; } 
        public decimal Low { get; set; }
        public decimal Close { get; set; }

        public bool ReversesDownFrom(StockQoute otherQoute)
        {
            return Open > otherQoute.High && Close < otherQoute.Low;
        }

        public bool ReversesUpFrom(StockQoute otherQoute)
        {
            return Open < otherQoute.Low && Close > otherQoute.High;
        }
    }
}
