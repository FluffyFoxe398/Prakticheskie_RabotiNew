﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static int Square(int n)
        {
            int sum = 0;
            for (int i = 1; i <= 2 * n - 1; i += 2)
            {
                sum += i;
            }
            return sum;
        }
        static int SumOfSquares(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += Square(i);
            }
            return sum;
        }

        static void Main()
        {
            Console.Write("Введите n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int result = SumOfSquares(n); // Используем метод
            Console.WriteLine("Сумма квадратов (через метод): " + result);

            Console.ReadKey();
        }
    }
}
