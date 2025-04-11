using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите строку: ");
            string input = Console.ReadLine();

            // Удаление лишних пробелов
            string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string cleaned = string.Join(" ", words);

            Console.WriteLine($"\nОбработанная строка: {cleaned}");
            Console.WriteLine($"Количество слов: {words.Length}");
            Console.WriteLine($"Длина строки: {cleaned.Length}");

            Console.ReadKey();
        }
    }
}
