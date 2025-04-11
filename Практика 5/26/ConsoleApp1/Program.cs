using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static int Min(int a, int b, int c)
        {
            int min = a;
            if (b < min) min = b;
            if (c < min) min = c;
            return min;
        }

        static void Main()
        {
            Console.Write("Введите число a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число c: ");
            int c = Convert.ToInt32(Console.ReadLine());

            int result = Min(a, b, c);
            Console.WriteLine($"Минимальное число: {result}");

            Console.ReadKey();
        }
    }
}
