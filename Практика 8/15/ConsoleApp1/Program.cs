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
            string path = "book.txt";

            if (!File.Exists(path))
            {
                Console.WriteLine("Файл book.txt не найден.");
                Console.ReadKey();
                return;
            }

            string[] lines = File.ReadAllLines(path);
            int lineCount = lines.Length;
            int charCount = 0;
            int wordCount = 0;

            foreach (string line in lines)
            {
                charCount += line.Length;
                wordCount += line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
            }

            Console.WriteLine($"Количество строк: {lineCount}");
            Console.WriteLine($"Количество символов: {charCount}");
            Console.WriteLine($"Количество слов: {wordCount}");

            Console.ReadKey();
        }
    }
}
