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
            Console.WriteLine("Решение уравнения ax + b = 0");

            Console.Write("Введите коэффициент a (не равно 0): ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Введите коэффициент b: ");
            double b = double.Parse(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("Ошибка: коэффициент a не может быть равен 0");
            }
            else
            {
                double x = -b / a;
                Console.WriteLine($"Решение: x = {x:F2}");  // Вывод с 2 знаками после запятой
            }
        }

    }
}
