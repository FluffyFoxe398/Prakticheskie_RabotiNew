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
            string inputPath = "secret.txt";
            string outputPath = "encrypted.txt";

            if (!File.Exists(inputPath))
            {
                Console.WriteLine("Файл secret.txt не найден.");
                Console.ReadKey();
                return;
            }

            string text = File.ReadAllText(inputPath);
            string result = "";

            foreach (char c in text)
            {
                result += char.IsLetter(c) ? '*' : c;
            }

            File.WriteAllText(outputPath, result);
            Console.WriteLine("Файл успешно зашифрован → encrypted.txt");

            Console.ReadKey();
        }
    }
}
