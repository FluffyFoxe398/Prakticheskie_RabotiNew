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
            Console.Write("Введите основную строку: ");
            string input = Console.ReadLine();

            Console.Write("Введите подстроку, которую нужно заменить: ");
            string oldSub = Console.ReadLine();

            Console.Write("Введите новую подстроку: ");
            string newSub = Console.ReadLine();

            string result = input.Replace(oldSub, newSub);

            Console.WriteLine($"Результат: {result}");

            Console.ReadKey();
        }
    }
}
