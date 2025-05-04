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
            Console.WriteLine("Нахождение наименьшего из четырех чисел");

            // Ввод и проверка чисел
            double a, b, c, d;
            do
            {
                Console.Write("Введите первое число: ");
                a = double.Parse(Console.ReadLine());
                Console.Write("Введите второе число: ");
                b = double.Parse(Console.ReadLine());
                Console.Write("Введите третье число: ");
                c = double.Parse(Console.ReadLine());
                Console.Write("Введите четвертое число: ");
                d = double.Parse(Console.ReadLine());

                if (a == b || a == c || a == d || b == c || b == d || c == d)
                    Console.WriteLine("Все числа должны быть разными!");
            } while (a == b || a == c || a == d || b == c || b == d || c == d);

            // Находим минимум последовательными сравнениями
            double min = a;
            if (b < min) min = b;
            if (c < min) min = c;
            if (d < min) min = d;

            Console.WriteLine($"Наименьшее число: {min:F4}");
        }


    }
}
