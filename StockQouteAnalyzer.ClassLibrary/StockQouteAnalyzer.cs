using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockQouteAnalyzer.ClassLibrary
{
    public class StockQouteAnalyzer
    {
        private readonly IList<StockQoute> _qoutes;

        public StockQouteAnalyzer(StockQouteCsvParser parser)
        {
            _qoutes = parser.ParseQoutes().ToList();
        }

        public IEnumerable<Reversal> FindReversals()
        {
            var locator = new ReversalLocator(_qoutes);
            return locator.Locate();
        }
    }
}
