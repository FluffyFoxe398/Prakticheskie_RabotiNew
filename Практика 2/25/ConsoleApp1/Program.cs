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
            Console.WriteLine("a⁸ за три операции:");
            Console.Write("Введите число a: ");
            double a = double.Parse(Console.ReadLine());

            a = a * a;  // a²
            a = a * a;  // a⁴
            a = a * a;  // a⁸

            Console.WriteLine($"Результат: {a}");
        }

    }
}
