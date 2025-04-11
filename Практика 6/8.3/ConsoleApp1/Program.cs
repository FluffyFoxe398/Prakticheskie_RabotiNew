using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static long Factorial(int num)
        {
            long fact = 1;
            for (int i = 2; i <= num; i++)
                fact *= i;
            return fact;
        }

        static void Main()
        {
            Console.Write("Введите n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            double sum = 0;
            for (int i = 2; i <= n; i++)
            {
                sum += 1.0 / Factorial(i);
            }

            Console.WriteLine($"Сумма ряда: {sum:F6}");

            Console.ReadKey();
        }
    }
}
