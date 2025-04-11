using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static double Perimeter(double a, double b, double c)
        {
            return a + b + c;
        }

        static void Main()
        {
            Console.Write("Введите сторону a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите сторону b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите сторону c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double p = Perimeter(a, b, c);
            Console.WriteLine($"Периметр треугольника: {p:F2}");

            Console.ReadKey();
        }
    }
}
