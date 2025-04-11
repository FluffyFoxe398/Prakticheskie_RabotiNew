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
            Console.Write("Введите строку (например, \"a1b2c3\"): ");
            string input = Console.ReadLine();

            string result = new string(input.Where(c => !char.IsDigit(c)).ToArray());

            Console.WriteLine($"Строка без цифр: {result}");

            Console.ReadKey();
        }
    }
}
