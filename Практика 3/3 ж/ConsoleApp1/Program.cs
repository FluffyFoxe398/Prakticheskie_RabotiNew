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
            Console.WriteLine("Задание 3ж: y → (z ≡ x)");
            Console.Write("Введите X (true/false): ");
            bool x = bool.Parse(Console.ReadLine());
            Console.Write("Введите Y (true/false): ");
            bool y = bool.Parse(Console.ReadLine());
            Console.Write("Введите Z (true/false): ");
            bool z = bool.Parse(Console.ReadLine());

            bool result = !y || (z == x);
            Console.WriteLine($"{y} → ({z} ≡ {x}) = {result}");
        }


    }
}
