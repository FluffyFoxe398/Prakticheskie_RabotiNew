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
            Console.WriteLine("a¹⁰ за четыре операции:");
            Console.Write("Введите число a: ");
            double a = double.Parse(Console.ReadLine());

            double a2 = a * a;   // a²
            double a4 = a2 * a2; // a⁴
            double a8 = a4 * a4; // a⁸
            a = a8 * a2;         // a¹⁰

            Console.WriteLine($"Результат: {a}");
        }

    }
}
