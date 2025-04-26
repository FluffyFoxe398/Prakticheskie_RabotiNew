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
            Console.WriteLine("Задание 1б: не (не А или не В) или А");
            Console.WriteLine("Введите значение A (true/false):");
            bool A = bool.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение B (true/false):");
            bool B = bool.Parse(Console.ReadLine());

            bool result = !(!A || !B) || A;
            Console.WriteLine($"не (не {A} или не {B}) или {A} = {result}");
        }


    }
}
