using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockDataOptimization
{
  public interface IStock
  {
    public string CompanyName { get; }
    public string StockSymbol { get; }
  }
}
