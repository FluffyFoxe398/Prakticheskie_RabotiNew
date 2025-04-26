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
            Console.WriteLine("Расчет суммы и произведения цифр четырёхзначного числа");

            // Ввод числа с проверкой
            int number;
            while (true)
            {
                Console.Write("Введите четырёхзначное число: ");
                if (int.TryParse(Console.ReadLine(), out number) && number >= 1000 && number <= 9999)
                    break;
                Console.WriteLine("Ошибка! Введите именно четырёхзначное число.");
            }

            // Получение цифр числа
            int digit1 = number / 1000;        // Первая цифра
            int digit2 = (number / 100) % 10;  // Вторая цифра
            int digit3 = (number / 10) % 10;   // Третья цифра
            int digit4 = number % 10;          // Четвертая цифра

            // Вычисление суммы и произведения
            int sum = digit1 + digit2 + digit3 + digit4;
            int product = digit1 * digit2 * digit3 * digit4;

            // Вывод результатов
            Console.WriteLine($"\nЦифры числа: {digit1}, {digit2}, {digit3}, {digit4}");
            Console.WriteLine($"Сумма цифр: {sum}");
            Console.WriteLine($"Произведение цифр: {product}");
        }

    }
}
