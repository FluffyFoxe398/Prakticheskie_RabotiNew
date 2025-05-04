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
            Console.WriteLine("Задание 1а: не (не А и не В) и А");
            Console.WriteLine("Введите значение A (true/false):");
            bool A = bool.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение B (true/false):");
            bool B = bool.Parse(Console.ReadLine());

            bool result = !(!A && !B) && A;
            Console.WriteLine($"не (не {A} и не {B}) и {A} = {result}");
        }


    }
}
