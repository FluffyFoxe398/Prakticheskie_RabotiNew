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
            string path = "input.txt";

            if (File.Exists(path))
            {
                string text = File.ReadAllText(path, Encoding.UTF8);
                Console.WriteLine("Содержимое файла:");
                Console.WriteLine(text);
            }
            else
            {
                Console.WriteLine("Файл input.txt не найден.");
            }

            Console.ReadKey();
        }
    }
}
