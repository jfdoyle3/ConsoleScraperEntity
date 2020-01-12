using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleScraperEntity
{
    class EntityWriteDB
    {
        public static void EntityWrite(List<List<string>> stockTable)
        {

            using (HapDBContext hapStocks = new HapDBContext())
            { 
               for (int row=0; row<stockTable.Count; row++)
                {
                    for (int col=0; col<stockTable.Count; col++)
                    {
                        Console.WriteLine( stockTable[row][col] ); 
                    }
                }
            }
        }
    }
}