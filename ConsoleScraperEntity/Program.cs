using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleScraperEntity
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<string>> stocks = YahooFinanceScraper.Login();
            EntityWriteDB.EntityWrite(stocks);
        }
    }
}
