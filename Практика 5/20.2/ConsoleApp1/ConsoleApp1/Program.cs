using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static double TotalDistance(int n)
        {
            double distance = 10;
            double total = 10;

            for (int i = 2; i <= n; i++)
            {
                distance *= 1.1;
                total += distance;
            }

            return total;
        }

        static void Main()
        {
            Console.Write("Введите количество дней (N): ");
            int n = Convert.ToInt32(Console.ReadLine());

            double result = TotalDistance(n);
            Console.WriteLine($"Суммарный путь за {n} дней: {result:F2} км");

            Console.ReadKey();
        }
    }
}
