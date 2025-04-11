using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static double TotalDistance(int steps)
        {
            double total = 0;

            for (int i = 2; i <= steps + 1; i++)
            {
                total += 1.0 / i;
            }

            return total;
        }

        static void Main()
        {
            Console.Write("Введите количество этапов (N): ");
            int steps = Convert.ToInt32(Console.ReadLine());

            double result = TotalDistance(steps);
            Console.WriteLine($"Общий путь: {result:F4} км");

            Console.ReadKey();
        }
    }
}
