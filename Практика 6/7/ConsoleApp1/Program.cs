using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            int[] prices = new int[15];
            Random rnd = new Random();

            for (int i = 0; i < prices.Length; i++)
                prices[i] = rnd.Next(20, 301);

            int min = prices[0];
            int index = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] < min)
                {
                    min = prices[i];
                    index = i;
                }
            }

            Console.WriteLine("Цены на товары:");
            foreach (var p in prices)
                Console.Write(p + " ");

            Console.WriteLine($"\nМинимальная цена: {min}, порядковый номер: {index + 1}");

            Console.ReadKey();
        }
    }
}
