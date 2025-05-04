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
            Console.WriteLine("Сравнение скоростей: км/ч и м/с");

            // Ввод данных с проверкой
            double kmh, ms;
            while (true)
            {
                try
                {
                    Console.Write("Введите скорость в км/ч: ");
                    kmh = double.Parse(Console.ReadLine());
                    Console.Write("Введите скорость в м/с: ");
                    ms = double.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Ошибка ввода! Введите числовые значения.");
                }
            }

            // Конвертация км/ч в м/с (1 км/ч = 1000/3600 м/с ≈ 0.277778 м/с)
            double kmhToMs = kmh * 1000 / 3600;

            // Сравнение с выводом результата
            Console.WriteLine("\nРезультат сравнения:");
            Console.WriteLine($"{kmh} км/ч = {kmhToMs:F6} м/с");
            Console.WriteLine($"{ms} м/с = {ms * 3.6:F6} км/ч");  // Обратная конвертация

            if (Math.Abs(kmhToMs - ms) < 0.000001)  // Учет погрешности при сравнении
            {
                Console.WriteLine("Скорости равны!");
            }
            else if (kmhToMs > ms)
            {
                Console.WriteLine($"{kmh} км/ч > {ms} м/с");
            }
            else
            {
                Console.WriteLine($"{kmh} км/ч < {ms} м/с");
            }
        }


    }
}
