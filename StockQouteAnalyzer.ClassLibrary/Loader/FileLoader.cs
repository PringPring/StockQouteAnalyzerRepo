using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockQouteAnalyzer.ClassLibrary
{
   public class FileLoader :IDataLoader
    {
        private readonly string _filename;

        public FileLoader(string filename)
        {
            _filename = filename;
        }

        public string[] LoadData()
        {
            return File.ReadAllLines(_filename);
        }
    }
}
