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
            Console.WriteLine("Оптимальное размещение костей домино на столе");

            // Ввод параметров стола
            Console.WriteLine("\nВведите размеры стола (a > b):");
            int a = ReadPositiveInt("Длина стола (a)");
            int b = ReadPositiveInt("Ширина стола (b)");
            if (a <= b)
            {
                Console.WriteLine("Ошибка: a должно быть больше b!");
                return;
            }

            // Ввод параметров кости домино
            Console.WriteLine("\nВведите размеры кости домино (c > d > e):");
            int c = ReadPositiveInt("Наибольший размер (c)");
            int d = ReadPositiveInt("Средний размер (d)");
            int e = ReadPositiveInt("Наименьший размер (e)");
            if (c <= d || d <= e)
            {
                Console.WriteLine("Ошибка: должны соблюдаться условия c > d > e!");
                return;
            }

            // Рассчет максимального количества для всех возможных ориентаций
            int maxCount = 0;
            string bestOrientation = "";

            // Вариант 1: Ориентация c x d (плоская)
            int count1 = (a / c) * (b / d);
            if (count1 > maxCount)
            {
                maxCount = count1;
                bestOrientation = $"c x d ({c}×{d}) - плоская";
            }

            // Вариант 2: Ориентация d x c (плоская, повернутая)
            int count2 = (a / d) * (b / c);
            if (count2 > maxCount)
            {
                maxCount = count2;
                bestOrientation = $"d x c ({d}×{c}) - плоская повернутая";
            }

            // Вариант 3: Ориентация c x e (реберная)
            int count3 = (a / c) * (b / e);
            if (count3 > maxCount)
            {
                maxCount = count3;
                bestOrientation = $"c x e ({c}×{e}) - реберная";
            }

            // Вариант 4: Ориентация e x c (реберная, повернутая)
            int count4 = (a / e) * (b / c);
            if (count4 > maxCount)
            {
                maxCount = count4;
                bestOrientation = $"e x c ({e}×{c}) - реберная повернутая";
            }

            // Вариант 5: Ориентация d x e (торцевая)
            int count5 = (a / d) * (b / e);
            if (count5 > maxCount)
            {
                maxCount = count5;
                bestOrientation = $"d x e ({d}×{e}) - торцевая";
            }

            // Вариант 6: Ориентация e x d (торцевая, повернутая)
            int count6 = (a / e) * (b / d);
            if (count6 > maxCount)
            {
                maxCount = count6;
                bestOrientation = $"e x d ({e}×{d}) - торцевая повернутая";
            }

            // Вывод результатов
            Console.WriteLine($"\nМаксимальное количество костей: {maxCount}");
            Console.WriteLine($"Оптимальная ориентация: {bestOrientation}");
            Console.WriteLine($"Размещение: {a / GetFirstDim(bestOrientation)} × {b / GetSecondDim(bestOrientation)}");
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

        static int GetFirstDim(string orientation)
        {
            return int.Parse(orientation.Split('×')[0].Split(' ').Last());
        }

        static int GetSecondDim(string orientation)
        {
            return int.Parse(orientation.Split('×')[1].Split(')')[0]);
        }


    }
}
