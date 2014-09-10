using StockQouteAnalyzer.ClassLibrary;
using StockQouteAnlyzer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace StockQouteAnlyzer
{
  class Program
    {
      //interbased program that separate doing from deciding and using point in not point out mechanism.
      //Uses powerful tiny abstraction that make the program testable and flexible.
        static void Main(string[] args)
        {
            string url = @"http://ichart.finance.yahoo.com/table.csv?s=MSFT&d=&&e=16&f=2011&g=d&a=2&b=13&c=1986&ignore=.csv";
            string localpath = @"c:\New folder\table.csv";

            var loader = GetLoadedFor(localpath);
            var parser = new StockQouteCsvParser(loader);
            var analyzer = new StockQouteAnalyzer.ClassLibrary.StockQouteAnalyzer(parser);
          
            foreach (var reversal in analyzer.FindReversals())
            {
                PrintReversal(reversal);
            }
            Console.ReadLine();

        }

        private static IDataLoader GetLoadedFor(string source)
        {
            IDataLoader loader;
            if (source.ToLower().StartsWith("http"))
            {
                loader = new WebLoader(source);
                Console.WriteLine("WebLoader  Loading File....");
            }
            else
            {
                loader = new FileLoader(source);
                Console.WriteLine("File Loader  ");
            }
            return loader;
        }
        private static void PrintReversal(Reversal reversal)
        {

            if (reversal.Direction == ReversalDirection.Up)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Reversed Up {0}", reversal.StockQoute.Date.ToShortDateString());
            }

            if (reversal.Direction == ReversalDirection.Down)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Reversed Down {0}", reversal.StockQoute.Date.ToShortDateString());
            }

        }

    }

}

