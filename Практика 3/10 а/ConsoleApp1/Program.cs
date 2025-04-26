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
            Console.WriteLine("Нахождение наибольшего из трех чисел");

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

            // Находим максимум последовательными сравнениями
            double max = a;
            if (b > max) max = b;
            if (c > max) max = c;

            Console.WriteLine($"Наибольшее число: {max}");
        }


    }
}
