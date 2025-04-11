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

            string text = File.ReadAllText(path);
            string[] words = text.Split(new[] { ' ', '\t', '\n', '\r', '.', ',', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            var shortWords = words.Where(word => word.Length <= 3);

            Console.WriteLine("Слова длиной ≤ 3 символов:");
            foreach (var word in shortWords)
                Console.WriteLine(word);

            Console.ReadKey();
        }
    }
}
