using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockDataOptimization
{
  class Program
  {
    // The purpose of this exercise is to better understand the Flyweight Pattern. While this program currently takes in any
    // sets of strings a user throws at it and immediately regurgitates them back, the guiding principle of the pattern is
    // evident, viz it creates objects and stores them within the program itself without the need for an external database.
    // Thereby avoiding object duplication.

    // ~FUTURE PROGRAMMING~
    // In the future, I would like to utilize a stock API to autofill the stocksDictionary. I would also like to allow the user
    // to lookup a stock by either the symbol or the company name and to look up many. I could even combine it with my prior program:
    // StockPriceMonitorySystem.
    public static void Main()
    {
      StockFactory stockFactory = new StockFactory();

      Console.WriteLine("STOCK LOOKUP");
      Console.WriteLine();
      Console.WriteLine("Enter stock symbol...");
      Console.WriteLine();

      string symbolInput = Console.ReadLine();

      Console.WriteLine();
      Console.WriteLine("Enter company name...");
      Console.WriteLine();

      string companyInput = Console.ReadLine();

      Stock stock = stockFactory.GetStock(symbolInput, companyInput);

      Console.WriteLine();
      Console.WriteLine($"{stock.ToString()}");
    }
  }
}