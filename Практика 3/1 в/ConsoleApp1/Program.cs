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
            Console.WriteLine("Задание 1в: не (не А или не В) и В");
            Console.WriteLine("Введите значение A (true/false):");
            bool A = bool.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение B (true/false):");
            bool B = bool.Parse(Console.ReadLine());

            bool result = !(!A || !B) && B;
            Console.WriteLine($"не (не {A} или не {B}) и {B} = {result}");
        }


    }
}
