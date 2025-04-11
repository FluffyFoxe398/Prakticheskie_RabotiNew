using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static int GetPow(int number, int power)
        {
            int result = 1;

            for (int i = 0; i < power; i++)
            {
                result *= number;
            }

            return result;
        }

        static void Main()
        {
            Console.Write("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите степень: ");
            int power = Convert.ToInt32(Console.ReadLine());

            int result = GetPow(number, power);
            Console.WriteLine($"{number} в степени {power} = {result}");

            Console.ReadKey();
        }
    }
}
