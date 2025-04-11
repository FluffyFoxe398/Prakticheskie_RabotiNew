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
            Console.Write("Введите символ: ");
            char ch = Console.ReadKey().KeyChar;
            Console.WriteLine();

            Console.WriteLine($"Код символа '{ch}' в Unicode: {(int)ch}");

            Console.ReadKey();
        }
    }
}
