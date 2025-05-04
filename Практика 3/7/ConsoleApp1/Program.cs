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
            Console.WriteLine("Задание 7: Вычисление значения функции y = sin(x) при x > 0, иначе y = cos(x)");
            Console.Write("Введите значение x (в радианах): ");
            double x = double.Parse(Console.ReadLine());

            double y;
            if (x > 0)
            {
                y = Math.Sin(x);
                Console.WriteLine($"При x = {x} > 0, y = sin({x}) = {y:F4}");
            }
            else
            {
                y = Math.Cos(x);
                Console.WriteLine($"При x = {x} <= 0, y = cos({x}) = {y:F4}");
            }
        }


    }
}
