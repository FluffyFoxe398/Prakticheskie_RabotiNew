using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Задание 2б: А и не (В и А или не С)");
            Console.Write("Введите A (true/false): ");
            bool A = bool.Parse(Console.ReadLine());
            Console.Write("Введите B (true/false): ");
            bool B = bool.Parse(Console.ReadLine());
            Console.Write("Введите C (true/false): ");
            bool C = bool.Parse(Console.ReadLine());

            bool result = A && !(B && A || !C);
            Console.WriteLine($"{A} и не ({B} и {A} или не {C}) = {result}");
        }


    }
}
