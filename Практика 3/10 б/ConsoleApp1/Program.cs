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
            Console.WriteLine("Нахождение наименьшего из трех чисел");

            // Ввод и проверка чисел
            double a, b, c;
            do
            {
                Console.Write("Введите первое число: ");
                a = double.Parse(Console.ReadLine());
                Console.Write("Введите второе число: ");
                b = double.Parse(Console.ReadLine());
                Console.Write("Введите третье число: ");
                c = double.Parse(Console.ReadLine());

                if (a == b || a == c || b == c)
                    Console.WriteLine("Числа должны быть разными!");
            } while (a == b || a == c || b == c);

            // Находим минимум последовательными сравнениями
            double min = a;
            if (b < min) min = b;
            if (c < min) min = c;

            Console.WriteLine($"Наименьшее число: {min}");
        }


    }
}
