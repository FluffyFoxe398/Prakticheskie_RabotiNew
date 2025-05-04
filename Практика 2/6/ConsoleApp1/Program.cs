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
            // Пример числа для округления
            double number = 3.14159265;

            // Округление до сотых
            double roundedNumber = Math.Round(number, 2);

            Console.WriteLine($"Исходное число: {number}");
            Console.WriteLine($"Округлённое до сотых: {roundedNumber}");

            // Дополнительно: ввод числа пользователем
            Console.WriteLine("\nВведите своё число для округления:");
            if (double.TryParse(Console.ReadLine(), out double userNumber))
            {
                Console.WriteLine($"Округлённое до сотых: {Math.Round(userNumber, 2)}");
            }
            else
            {
                Console.WriteLine("Ошибка! Введено не число.");
            }
        }

    }
}
