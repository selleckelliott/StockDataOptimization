using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockDataOptimization
{
  public class StockFactory
  {
    //Checks if a stock is already listed. If not, new stock is created.

    Dictionary<string, Stock> stocksDictionary = new Dictionary<string, Stock>();
    public Stock GetStock(string stockSymbol, string companyName)
    {
      stocksDictionary.TryGetValue(stockSymbol, out Stock stock);

      if (stock == null)
      {
        stock = new Stock(stockSymbol, companyName);
        stocksDictionary.Add(stockSymbol, stock);
      }

      return stock;
    }
  }
}
