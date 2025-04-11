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
            string path = "text.txt";

            if (!File.Exists(path))
            {
                Console.WriteLine("Файл text.txt не найден.");
                Console.ReadKey();
                return;
            }

            Console.Write("Введите слово для поиска: ");
            string word = Console.ReadLine();

            string content = File.ReadAllText(path);
            int count = Regex.Matches(content, $@"\b{Regex.Escape(word)}\b", RegexOptions.IgnoreCase).Count;

            Console.WriteLine($"Слово \"{word}\" встречается {count} раз(а).");

            Console.ReadKey();
        }
    }
}
