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
            Console.WriteLine("Задание 3е: (x ≡ (z ∨ y)) ∨ ((x→ z) ∧ (y → x))");
            Console.Write("Введите X (true/false): ");
            bool x = bool.Parse(Console.ReadLine());
            Console.Write("Введите Y (true/false): ");
            bool y = bool.Parse(Console.ReadLine());
            Console.Write("Введите Z (true/false): ");
            bool z = bool.Parse(Console.ReadLine());

            bool part1 = x == (z || y);
            bool part2 = (!x || z) && (!y || x);
            bool result = part1 || part2;

            Console.WriteLine($"({x} ≡ ({z} ∨ {y})) ∨ (({x}→{z}) ∧ ({y}→{x})) = {result}");
        }


    }
}
