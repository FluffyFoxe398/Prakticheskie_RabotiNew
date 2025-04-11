using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static long Factorial(int k)
        {
            long result = 1;
            for (int i = 1; i <= k; i++)
            {
                result *= i;
            }
            return result;
        }

        static double SumFactorialSeries(int n)
        {
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += 1.0 / Factorial(i);
            }
            return sum;
        }

        static void Main()
        {
            Console.Write("Введите n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            double result = SumFactorialSeries(n);
            Console.WriteLine("Сумма ряда: " + result);

            Console.ReadKey();
        }
    }
}
