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
            Console.WriteLine("a⁶ за три операции:");
            Console.Write("Введите число a: ");
            double a = double.Parse(Console.ReadLine());

            double a2 = a * a;   // a²
            double a3 = a2 * a;  // a³
            a = a3 * a3;        // a⁶

            Console.WriteLine($"Результат: {a}");
        }

    }
}
