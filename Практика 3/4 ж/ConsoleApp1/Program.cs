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
            Console.WriteLine("Задание 4ж: x > 3 или x < 1");
            Console.Write("Введите число x: ");
            double x = double.Parse(Console.ReadLine());

            bool result = x > 3 || x < 1;
            Console.WriteLine($"{x} > 3 или {x} < 1 = {result}");
        }

    }
}
