using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockDataOptimization
{
  public class Stock : IStock
  {
    private readonly string _companyName;

    private readonly string _stockSymbol;
    public Stock(string companyName, string stockSymbol)
    {
      _companyName = companyName;
      _stockSymbol = stockSymbol;
    }

    public string CompanyName => _companyName;

    public string StockSymbol => _stockSymbol;

    public override string ToString()
    {
      return $"Stock Symbol: {_stockSymbol}, Company Name: {_companyName}";
    }
  }
}
