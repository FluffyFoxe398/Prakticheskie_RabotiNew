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
            Console.WriteLine("Задание 4д: x < 0 и y > 5");
            Console.Write("Введите число x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Введите число y: ");
            double y = double.Parse(Console.ReadLine());

            bool result = x < 0 && y > 5;
            Console.WriteLine($"{x} < 0 и {y} > 5 = {result}");
        }


    }
}
