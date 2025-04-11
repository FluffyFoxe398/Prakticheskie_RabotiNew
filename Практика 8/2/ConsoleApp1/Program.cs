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
            char ch = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (char.IsLetter(ch))
            {
                char result = char.IsUpper(ch) ? char.ToLower(ch) : char.ToUpper(ch);
                Console.WriteLine($"Преобразованная буква: {result}");
            }
            else
            {
                Console.WriteLine("Это не буква.");
            }

            Console.ReadKey();
        }
    }
}
