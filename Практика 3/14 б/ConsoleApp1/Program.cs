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
            Console.WriteLine("Проверка нечетности последней цифры числа");

            int number;
            while (true)
            {
                Console.Write("Введите натуральное число: ");
                if (int.TryParse(Console.ReadLine(), out number) && number > 0)
                    break;
                Console.WriteLine("Ошибка! Введите целое число больше 0.");
            }

            // Получаем последнюю цифру
            int lastDigit = number % 10;
            bool isOdd = lastDigit % 2 != 0;

            Console.WriteLine($"\nЧисло: {number}");
            Console.WriteLine($"Последняя цифра: {lastDigit}");
            Console.WriteLine($"Заканчивается на нечетную цифру: {isOdd}");
        }


    }
}
