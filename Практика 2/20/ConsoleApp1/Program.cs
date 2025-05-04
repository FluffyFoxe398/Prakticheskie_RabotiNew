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
            Console.WriteLine("Расчет периметра прямоугольного треугольника");

            Console.Write("Введите первый катет a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Введите второй катет b: ");
            double b = double.Parse(Console.ReadLine());

            double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)); // Гипотенуза
            double P = a + b + c;

            Console.WriteLine($"Периметр треугольника: {P:F2}");
        }

    }
}
