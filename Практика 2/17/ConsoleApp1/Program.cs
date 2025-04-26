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
            Console.WriteLine("Решение уравнения ax² - bx + c = e");

            Console.Write("Введите коэффициент a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Введите коэффициент b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Введите коэффициент c: ");
            double c = double.Parse(Console.ReadLine());

            Console.Write("Введите значение e: ");
            double e = double.Parse(Console.ReadLine());

            // Переносим e в левую часть: ax² - bx + (c - e) = 0
            c = c - e;

            // Вычисляем дискриминант
            double discriminant = Math.Pow(b, 2) - 4 * a * c;

            if (discriminant < 0)
            {
                Console.WriteLine("Действительных корней нет");
            }
            else if (discriminant == 0)
            {
                double x = b / (2 * a);
                Console.WriteLine($"Уравнение имеет один корень: x = {x:F2}");
            }
            else
            {
                double x1 = (b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine($"Уравнение имеет два корня: x1 = {x1:F2}, x2 = {x2:F2}");
            }
        }

    }
}
