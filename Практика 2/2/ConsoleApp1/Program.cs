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
            Random rnd = new Random(); // Генератор случайных чисел

            Console.WriteLine("Введите начало диапазона (a):");
            int a = int.Parse(Console.ReadLine()); // Ввод a

            Console.WriteLine("Введите конец диапазона (b):");
            int b = int.Parse(Console.ReadLine()); // Ввод b

            // Проверка, чтобы a было меньше b (иначе поменяем местами)
            if (a > b)
            {
                int temp = a;
                a = b;
                b = temp;
            }

            // Генерация случайного числа в диапазоне [a, b)
            int randomNumber = rnd.Next(a, b);

            Console.WriteLine($"Случайное число в диапазоне [{a}, {b}): {randomNumber}");
        }

    }
}
