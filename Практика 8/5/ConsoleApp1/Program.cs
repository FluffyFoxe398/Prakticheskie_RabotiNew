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

            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            string reversed = new string(chars);

            Console.WriteLine($"Перевёрнутая строка: {reversed}");

            Console.ReadKey();
        }
    }
}
