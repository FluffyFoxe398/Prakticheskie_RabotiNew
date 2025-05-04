using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Введите первое число:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            int num2 = int.Parse(Console.ReadLine());

            double product = num1 * num2;
            double geometricMean = Math.Sqrt(product);  // Корень квадратный (степень 2)
            Console.WriteLine($"Среднее геометрическое: {geometricMean}");
        }

    }
}
