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
            Console.Write("Введите букву: ");
            char ch = char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine();

            if ("aeiouy".Contains(ch))
                Console.WriteLine("Это гласная буква.");
            else
                Console.WriteLine("Это не гласная буква.");

            Console.ReadKey();
        }
    }
}
