using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockQouteAnalyzer.ClassLibrary
{
  public  interface IDataLoader
    {
        string[] LoadData();
    }
}
