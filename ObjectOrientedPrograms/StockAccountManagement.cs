using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPrograms
{
    public class StockAccountManagement
    {
        public static List<Stock> st = new List<Stock>();

        public class Stock
        {
            public string StockName { get; set; }
            public int shares { get; set; }
            public int Price { get; set; }
        }
        public static void AddStock()
        {
            for (int i = 0; i <2; i++)
            {
                Stock st1 = new Stock();
                Console.WriteLine("Enter the stock name: ");
                st1.StockName = Console.ReadLine();
                Console.WriteLine("Enter number of shares ");
                st1.shares = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the stock price: ");
                st1.Price = Convert.ToInt32(Console.ReadLine());
                st.Add(st1);
            }
        }
        public static void DisplayStocks()
        {
            int totalvalue = 0;
            Console.WriteLine("Stock Details");
            foreach (var i in st)
            {
                Console.WriteLine("Stock name is: " + i.StockName);
                Console.WriteLine("Stock share is: " + i.shares);
                Console.WriteLine("Stock name is: " + i.Price);
                totalvalue = i.shares * i.Price;
                Console.WriteLine("Total stock price for {0} is : {1}", i.StockName, totalvalue);
                Console.WriteLine("-------------------");
            }
        }
    }
}