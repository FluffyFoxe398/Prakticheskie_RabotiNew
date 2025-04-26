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
            Console.WriteLine("Сравнение площади круга и квадрата");

            // Ввод данных с проверкой
            double radius, side;
            while (true)
            {
                try
                {
                    Console.Write("Введите радиус круга (R > 0): ");
                    radius = double.Parse(Console.ReadLine());
                    Console.Write("Введите сторону квадрата (a > 0): ");
                    side = double.Parse(Console.ReadLine());

                    if (radius > 0 && side > 0) break;
                    Console.WriteLine("Значения должны быть положительными!");
                }
                catch
                {
                    Console.WriteLine("Ошибка ввода! Введите числовые значения.");
                }
            }

            // Вычисление площадей
            double circleArea = Math.PI * Math.Pow(radius, 2);
            double squareArea = Math.Pow(side, 2);

            // Сравнение и вывод результата
            Console.WriteLine("\nРезультаты расчетов:");
            Console.WriteLine($"Площадь круга: {circleArea:F4}");
            Console.WriteLine($"Площадь квадрата: {squareArea:F4}");

            if (Math.Abs(circleArea - squareArea) < 0.0001)
            {
                Console.WriteLine("Площади равны!");
            }
            else if (circleArea > squareArea)
            {
                Console.WriteLine("Площадь круга больше площади квадрата");
            }
            else
            {
                Console.WriteLine("Площадь квадрата больше площади круга");
            }
        }


    }
}
