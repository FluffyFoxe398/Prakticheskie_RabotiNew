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

            string reversed = string.Join("", input.Reverse());

            Console.WriteLine($"Результат: {reversed}");

            Console.ReadKey();
        }
    }
}
