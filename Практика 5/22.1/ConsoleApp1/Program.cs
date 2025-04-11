using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static double YieldOnYear(int n)
        {
            double yield = 20; // в ц/га

            for (int i = 1; i < n; i++)
            {
                yield *= 1.02; // +2% каждый год
            }

            return yield;
        }

        static void Main()
        {
            Console.Write("Введите номер года (N): ");
            int n = Convert.ToInt32(Console.ReadLine());

            double result = YieldOnYear(n);
            Console.WriteLine($"Урожайность на {n}-й год: {result:F2} ц/га");

            Console.ReadKey();
        }
    }
}
