using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            int[,] matrix = new int[5, 8];
            Random rnd = new Random();

            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 8; j++)
                    matrix[i, j] = rnd.Next(-10, 20);

            Console.WriteLine("Матрица 5x8:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 8; j++)
                    Console.Write(matrix[i, j].ToString().PadLeft(4));
                Console.WriteLine();
            }

            Console.WriteLine("\nСтолбцы с хотя бы одним отрицательным элементом:");
            for (int j = 0; j < 8; j++)
            {
                bool hasNegative = false;
                for (int i = 0; i < 5; i++)
                {
                    if (matrix[i, j] < 0)
                    {
                        hasNegative = true;
                        break;
                    }
                }

                if (hasNegative)
                    Console.WriteLine($"Столбец {j + 1}");
            }

            Console.ReadKey();
        }
    }
}
