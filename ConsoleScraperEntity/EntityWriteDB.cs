using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleScraperEntity
{
    class EntityWriteDB
    {
        public static void EntityWrite(List<List<string>> stockData)
        {
            
            using (HapDBContext db = new HapDBContext())
            {
                string method = "HAP";

                for (int i = 0; i < stockData.Count; i++)
                {

                    HAPStock stockTable = new HAPStock
                    {
                        DateStamp = DateTime.Now,
                        Symbol = stockData[i][0].ToString(),
                        LastPrice = stockData[i][1].ToString(),
                        Change = stockData[i][2].ToString(),
                        ChgPc = stockData[i][3].ToString(),
                        MarketTime = stockData[i][5].ToString(),
                        Volume = stockData[i][6].ToString(),
                        AvgVol3m = stockData[i][8].ToString(),
                        MarketCap = stockData[i][12].ToString(),
                        Method = method,

                    };

                    db.HAPStocks.Add(stockTable);
                    db.SaveChanges();
                }

                Console.WriteLine("All data in the database:");
            }
        }
    }
}