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
            Console.Write("Введите значение x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите максимальную степень n (нечётное число): ");
            int n = Convert.ToInt32(Console.ReadLine());

            double sum = 0;

            for (int i = 1; i <= n; i += 2)
            {
                double term = Math.Pow(x, i) / i;
                sum += ((i / 2) % 2 == 0) ? term : -term;
            }

            Console.WriteLine($"Сумма ряда: {sum:F4}");

            Console.ReadKey();
        }
    }
}
