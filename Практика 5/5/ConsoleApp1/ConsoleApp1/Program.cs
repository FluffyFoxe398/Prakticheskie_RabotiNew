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

        static void Main()
        {
            Console.Write("Введите число для факториала: ");
            int k = Convert.ToInt32(Console.ReadLine());

            long result = Factorial(k);
            Console.WriteLine($"{k}! = {result}");

            Console.ReadKey();
        }
    }
}
