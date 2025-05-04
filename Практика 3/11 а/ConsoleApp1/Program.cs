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
            Console.WriteLine("Нахождение наибольшего из четырех чисел");

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

            // Находим максимум последовательными сравнениями
            double max = a;
            if (b > max) max = b;
            if (c > max) max = c;
            if (d > max) max = d;

            Console.WriteLine($"Наибольшее число: {max:F4}");
        }


    }
}
