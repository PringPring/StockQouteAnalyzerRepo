using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockQouteAnalyzer.ClassLibrary
{
   public class Reversal
    {
        public Reversal(StockQoute qoute, ReversalDirection direction)
        {
            StockQoute = qoute;
            Direction = direction;

        }
        public ReversalDirection Direction { get; set; }
        public StockQoute StockQoute { get; set; }
    }
}
