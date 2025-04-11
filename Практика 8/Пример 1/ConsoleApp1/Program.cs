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
            Console.Write("Введите один символ: ");
            char ch = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (char.IsDigit(ch))
            {
                Console.WriteLine("Это цифра.");
            }
            else if (char.IsLetter(ch))
            {
                Console.WriteLine("Это буква.");
                Console.WriteLine($"Верхний регистр: {char.ToUpper(ch)}");
                Console.WriteLine($"Нижний регистр: {char.ToLower(ch)}");
            }
            else
            {
                Console.WriteLine("Это не цифра и не буква.");
            }

            Console.ReadKey();
        }
    }
}
