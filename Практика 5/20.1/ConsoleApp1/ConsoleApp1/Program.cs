using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static double DistanceOnDay(int n)
        {
            double distance = 10;

            for (int i = 2; i <= n; i++)
            {
                distance *= 1.1; // увеличение на 10%
            }

            return distance;
        }

        static void Main()
        {
            Console.Write("Введите номер дня (N): ");
            int n = Convert.ToInt32(Console.ReadLine());

            double result = DistanceOnDay(n);
            Console.WriteLine($"Пробег на {n}-й день: {result:F2} км");

            Console.ReadKey();
        }
    }
}
