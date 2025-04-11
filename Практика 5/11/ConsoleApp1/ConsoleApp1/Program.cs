using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static double PowerSeries(double x)
        {
            double a = x;
            double sum = a;
            for (int i = 1; i <= 10; i += 2)
            {
                a = a * x * x * (2*i - 1) / (2 * i + 1);
                sum += a;
            }

            return sum;
        }

        static void Main()
        {
            Console.Write("Введите x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            double result = PowerSeries(x);
            Console.WriteLine("Сумма ряда: " + result);

            Console.ReadKey();
        }
    }
}
