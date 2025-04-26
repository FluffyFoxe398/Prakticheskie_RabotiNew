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
            Console.WriteLine("Задание 2а: не (А или не В и С)");
            Console.Write("Введите A (true/false): ");
            bool A = bool.Parse(Console.ReadLine());
            Console.Write("Введите B (true/false): ");
            bool B = bool.Parse(Console.ReadLine());
            Console.Write("Введите C (true/false): ");
            bool C = bool.Parse(Console.ReadLine());

            bool result = !(A || !B && C);
            Console.WriteLine($"не ({A} или не {B} и {C}) = {result}");
        }


    }
}
