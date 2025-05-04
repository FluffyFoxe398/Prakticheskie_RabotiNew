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
            Console.WriteLine("Оптимальное размещение прямоугольников на столе");

            // Ввод параметров стола
            Console.WriteLine("\nВведите размеры стола (a > b):");
            int a = ReadPositiveInt("Длина стола (a)");
            int b = ReadPositiveInt("Ширина стола (b)");
            if (a <= b)
            {
                Console.WriteLine("Ошибка: a должно быть больше b!");
                return;
            }

            // Ввод параметров прямоугольников
            Console.WriteLine("\nВведите размеры прямоугольника (c > d):");
            int c = ReadPositiveInt("Длина прямоугольника (c)");
            int d = ReadPositiveInt("Ширина прямоугольника (d)");
            if (c <= d)
            {
                Console.WriteLine("Ошибка: c должно быть больше d!");
                return;
            }

            // Расчет количества для двух вариантов размещения
            int count1 = (a / c) * (b / d);  // Длинной стороной вдоль длинной стороны стола
            int count2 = (a / d) * (b / c);  // Длинной стороной вдоль короткой стороны стола

            // Определение оптимального варианта
            string result;
            if (count1 > count2)
            {
                result = $"лучше размещать длинной стороной вдоль длинной стороны стола ({count1} > {count2})";
            }
            else if (count2 > count1)
            {
                result = $"лучше размещать длинной стороной вдоль короткой стороны стола ({count2} > {count1})";
            }
            else
            {
                result = $"количество одинаково в обоих вариантах ({count1})";
            }

            // Вывод результатов
            Console.WriteLine($"\nРезультаты:");
            Console.WriteLine($"1. Длинной вдоль длинной: {count1} прямоугольников");
            Console.WriteLine($"2. Длинной вдоль короткой: {count2} прямоугольников");
            Console.WriteLine($"\nОптимально: {result}");
        }

        static int ReadPositiveInt(string prompt)
        {
            while (true)
            {
                Console.Write($"{prompt}: ");
                if (int.TryParse(Console.ReadLine(), out int value) && value > 0)
                    return value;
                Console.WriteLine("Ошибка! Введите целое число больше 0.");
            }
        }


    }
}
