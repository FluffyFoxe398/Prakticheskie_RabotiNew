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
            float z;
            int a = 1, b = 2, c = 3;
            const int m = 3;

            z = (a + b + c) / m;  // Проблема: целочисленное деление

            Console.WriteLine($"Результат (ошибка): {z}");  // Выведет 2 (неверно)

            // Правильное решение:
            z = (float)(a + b + c) / m;
            Console.WriteLine($"Правильный результат: {z}");  // Выведет 2.0
        }

    }
}
