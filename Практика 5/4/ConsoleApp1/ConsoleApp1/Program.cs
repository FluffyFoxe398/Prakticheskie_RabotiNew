using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void PrintRow(int M, int N)
        {
            for (int i = 0; i < N; i++)
            {
                Console.Write(M + " ");
            }
            Console.WriteLine(); // переход на новую строку
        }

        static void Main()
        {
            Console.Write("Введите число M: ");
            int M = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите длину ряда N: ");
            int N = Convert.ToInt32(Console.ReadLine());

            PrintRow(M, N);
            Console.ReadKey();
        }
    }
}
