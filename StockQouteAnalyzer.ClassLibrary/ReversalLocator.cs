using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockQouteAnalyzer.ClassLibrary
{
   public class ReversalLocator
    {
        private readonly IList<StockQoute> _qoutes;

        public ReversalLocator(IList<StockQoute> qoutes)
        {
            _qoutes = qoutes;
        }

        public IEnumerable<Reversal> Locate()
        {
            for (int i = 0; i < _qoutes.Count - 1; i++)
            {
                if (_qoutes[i].ReversesDownFrom(_qoutes[i + 1]))
                {
                    yield return new Reversal(_qoutes[i], ReversalDirection.Down);
                }
                if (_qoutes[i].ReversesUpFrom(_qoutes[i + 1]))
                {
                    yield return new Reversal(_qoutes[i], ReversalDirection.Up);
                }
            }
        }
    }
}
