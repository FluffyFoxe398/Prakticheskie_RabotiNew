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
            Console.WriteLine("Нахождение гипотенузы прямоугольного треугольника");

            Console.Write("Введите длину первого катета (a): ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Введите длину второго катета (b): ");
            double b = double.Parse(Console.ReadLine());

            // Вычисляем гипотенузу по теореме Пифагора
            double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

            Console.WriteLine($"Длина гипотенузы: {c:F2}");
        }

    }
}
