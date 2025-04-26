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
            Console.WriteLine("Задание 4в: x < 1 или y < 2");
            Console.Write("Введите число x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Введите число y: ");
            double y = double.Parse(Console.ReadLine());

            bool result = x < 1 || y < 2;
            Console.WriteLine($"{x} < 1 или {y} < 2 = {result}");
        }


    }
}
