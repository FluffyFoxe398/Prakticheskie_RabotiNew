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
            Console.WriteLine("Определение максимального и минимального из двух чисел");

            // Ввод данных с проверкой на различия
            double num1, num2;
            do
            {
                Console.Write("Введите первое число: ");
                num1 = double.Parse(Console.ReadLine());
                Console.Write("Введите второе число: ");
                num2 = double.Parse(Console.ReadLine());

                if (num1 == num2)
                {
                    Console.WriteLine("Числа должны быть разными! Повторите ввод.");
                }
            } while (num1 == num2);

            // Определение максимального и минимального
            double max = Math.Max(num1, num2);
            double min = Math.Min(num1, num2);

            // Альтернативный вариант без Math:
            // double max = num1 > num2 ? num1 : num2;
            // double min = num1 < num2 ? num1 : num2;

            // Вывод результата
            Console.WriteLine($"\nРезультат:");
            Console.WriteLine($"Максимальное число: {max}");
            Console.WriteLine($"Минимальное число: {min}");
        }


    }
}
