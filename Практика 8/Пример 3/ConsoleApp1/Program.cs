using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            string inputFile = "input.txt";
            string outputFile = "output.txt";

            if (File.Exists(inputFile))
            {
                string text = File.ReadAllText(inputFile, Encoding.UTF8);
                string result = new string(text.Select(c => char.IsDigit(c) ? '#' : c).ToArray());

                File.WriteAllText(outputFile, result, Encoding.UTF8);
                Console.WriteLine("Файл успешно обработан и записан в output.txt");
            }
            else
            {
                Console.WriteLine("Файл input.txt не найден.");
            }

            Console.ReadKey();
        }
    }
}
