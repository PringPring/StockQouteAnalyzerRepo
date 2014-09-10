using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockQouteAnalyzer.ClassLibrary
{
  public  class StockQouteCsvParser : IStockQouteParser
    {

        private readonly IDataLoader _loader;

        public StockQouteCsvParser(IDataLoader loader)
        {
            _loader = loader;
        }

        public IList<StockQoute> ParseQoutes()
        {
            var csvData = _loader.LoadData();
            return (
                from line in csvData.Skip(1)
                let data = line.Split(',')
                where data[0] != string.Empty
                select new StockQoute()
                {
                    Date = DateTime.Parse(data[0]),
                    Open = decimal.Parse(data[1]),
                    High = decimal.Parse(data[2]),
                    Low = decimal.Parse(data[3]),
                    Close = decimal.Parse(data[4])
                }).ToList();
        }
    }
}
