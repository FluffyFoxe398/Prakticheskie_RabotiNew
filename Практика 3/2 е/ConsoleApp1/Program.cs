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
            Console.WriteLine("Задание 2е: не (не А или В и С) или А");
            Console.Write("Введите A (true/false): ");
            bool A = bool.Parse(Console.ReadLine());
            Console.Write("Введите B (true/false): ");
            bool B = bool.Parse(Console.ReadLine());
            Console.Write("Введите C (true/false): ");
            bool C = bool.Parse(Console.ReadLine());

            bool result = !(!A || B && C) || A;
            Console.WriteLine($"не (не {A} или {B} и {C}) или {A} = {result}");
        }


    }
}
