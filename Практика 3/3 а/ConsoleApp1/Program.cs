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
            Console.WriteLine("Задание 3а: (x ∨ y) → (у ≡ x)");
            Console.Write("Введите X (true/false): ");
            bool x = bool.Parse(Console.ReadLine());
            Console.Write("Введите Y (true/false): ");
            bool y = bool.Parse(Console.ReadLine());

            bool result = !(x || y) || (y == x);
            Console.WriteLine($"({x} ∨ {y}) → ({y} ≡ {x}) = {result}");
        }


    }
}
