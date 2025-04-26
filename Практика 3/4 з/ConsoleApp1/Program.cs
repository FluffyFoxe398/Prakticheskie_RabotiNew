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
            Console.WriteLine("Задание 4з: 0 < y < 4 и x < 5");
            Console.Write("Введите число x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Введите число y: ");
            double y = double.Parse(Console.ReadLine());

            bool result = y > 0 && y < 4 && x < 5;
            Console.WriteLine($"0 < {y} < 4 и {x} < 5 = {result}");
        }


    }
}
