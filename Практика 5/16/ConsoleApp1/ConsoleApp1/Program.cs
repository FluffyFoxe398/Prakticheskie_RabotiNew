using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void PrintFibonacci(int max)
        {
            int a = 0, b = 1;

            Console.Write("Последовательность Фибоначчи до " + max + ": ");
            while (a <= max)
            {
                Console.Write(a + " ");
                int temp = a + b;
                a = b;
                b = temp;
            }
            Console.WriteLine();
        }

        static void Main()
        {
            Console.Write("Введите значение M: ");
            int m = Convert.ToInt32(Console.ReadLine());

            PrintFibonacci(m);

            Console.ReadKey();
        }
    }
}
