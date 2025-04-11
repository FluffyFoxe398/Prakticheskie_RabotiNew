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
            int[,] matrix = new int[6, 11];
            Random rnd = new Random();

            for (int i = 0; i < 6; i++)
                for (int j = 0; j < 11; j++)
                    matrix[i, j] = rnd.Next(0, 100);

            Console.WriteLine("Матрица 6x11:");
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 11; j++)
                    Console.Write(matrix[i, j].ToString().PadLeft(4));
                Console.WriteLine();
            }

            int totalSum = 0;
            for (int i = 0; i < 6; i++)
            {
                int max = matrix[i, 0];
                for (int j = 1; j < 11; j++)
                    if (matrix[i, j] > max)
                        max = matrix[i, j];
                totalSum += max;
            }

            Console.WriteLine($"\nСумма максимальных элементов каждой строки: {totalSum}");

            Console.ReadKey();
        }
    }
}
