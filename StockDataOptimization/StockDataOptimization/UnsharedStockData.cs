using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockDataOptimization
{
  public class UnsharedStockData
  {
    public decimal Price { get; set; }
    public decimal Bid { get; set; }
    public decimal Ask { get; set; }
    public decimal YesterdaysClose { get; set; }
    public decimal OpenPrice { get; set; }
  }
}
