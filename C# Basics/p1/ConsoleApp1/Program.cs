using ConsoleApp1;
using System.Security.Cryptography;

using ConsoleApp2;
 
namespace ConsolApp1 // Note: actual namespace depends on the project name.
{
    public delegate bool sumDel(int x, int y);
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] a = new int[] { 1, 2, 3, 4, -5, 6,-7, -8, -9 };
            int[] b = new int[] { 1, 2, 3, -4, 5, 6, 7, 8, 9 } ;
            var ret = testDel(a, b, (x, y) => x > 0 && y > 0) ;
            Console.WriteLine(ret);

        }
        public static int testDel(int []x,int []y,sumDel del)
        {
            int sum = 0;
            for(int i = 0; i < x.Length; i++)
            {
                if (del(x[i], y[i]))
                {
                    sum += x[i] + y[i];
                }
                 
            }
            return sum;

        }

        public void EventTest()
        {
            Stock stock = new Stock("Amazon", 290.00d);
            stock.StockPriceChange += Stock_StockPriceChange;
            stock.StockPriceChange += Output;
            stock.ChangeStockPriceBy(.02d);
            stock.ChangeStockPriceBy(.00);
            stock.ChangeStockPriceBy(-.04);


        }
        private static void Output(Stock s, double OldPrice)
        {
            Console.WriteLine("Event was Called");


        }
        private static void Stock_StockPriceChange(Stock s, double OldPrice)
        {
            if (s.Price > OldPrice)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Smaller Price");
            }
            else if (s.Price == OldPrice)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Same price");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Greater Price");
            }
        }
    }
}

    

 

 