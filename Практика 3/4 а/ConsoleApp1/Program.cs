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
            Console.WriteLine("Задание 4а: x < 2 и y < 3");
            Console.Write("Введите число x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Введите число y: ");
            double y = double.Parse(Console.ReadLine());

            bool result = x < 2 && y < 3;
            Console.WriteLine($"{x} < 2 и {y} < 3 = {result}");
        }


    }
}
