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
            Console.WriteLine("Введите целое число:");
            int number = int.Parse(Console.ReadLine());

            int square = number * number;
            Console.WriteLine($"Квадрат числа {number} равен {square}");
        }

    }
}
