using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static int SquareByOddSum(int n)
        {
            int result = 0;
            int currentOdd = 1;

            for (int i = 0; i < n; i++)
            {
                result += currentOdd;
                currentOdd += 2;
            }

            return result;
        }

        static void Main()
        {
            Console.Write("Введите число n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int square = SquareByOddSum(n);
            Console.WriteLine($"{n} в квадрате = {square}");

            Console.ReadKey();
        }
    }
}
