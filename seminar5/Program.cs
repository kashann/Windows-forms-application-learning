using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar5
{
    class Program
    {
        static void Main(string[] args)
        {
            var stock = new Stock();
            stock.PriceChanged += DisplayStockPrice;
            stock.Price = 30;
            stock.Price = 31;

            int? temperature = null; //stored in the heap
            //NUllabel<int> Same thing as (int?)
        }

        static void DisplayStockPrice (decimal oldPrice, decimal newPrice)
        {
            Console.WriteLine("OldPrice: " + oldPrice + " & NewPrice: " + newPrice);
        }
    }
}
