using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace StockQouteAnalyzer.ClassLibrary
{
   public class WebLoader : IDataLoader
    {
        private readonly string _url;
        public WebLoader(string url)
        {
            _url = url;
        }

        public string[] LoadData()
        {
            var client = new WebClient();
            return client.DownloadString(new Uri(_url)).Split('\n');


        }
    }
}
