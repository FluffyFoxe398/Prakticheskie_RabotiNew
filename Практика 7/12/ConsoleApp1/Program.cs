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
            int[,] matrix = new int[6, 6];
            Random rnd = new Random();

            for (int i = 0; i < 6; i++)
                for (int j = 0; j < 6; j++)
                    matrix[i, j] = rnd.Next(1, 100);

            Console.WriteLine("Исходная матрица:");
            Print(matrix);

            for (int i = 0; i < 6; i++)
            {
                int minIndex = 0;
                for (int j = 1; j < 6; j++)
                {
                    if (matrix[i, j] < matrix[i, minIndex])
                        minIndex = j;
                }

                // Обмен первого с минимальным
                (matrix[i, 0], matrix[i, minIndex]) = (matrix[i, minIndex], matrix[i, 0]);
            }

            Console.WriteLine("\nМатрица после замены минимумов с первым элементом строки:");
            Print(matrix);

            Console.ReadKey();
        }

        static void Print(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write(matrix[i, j].ToString().PadLeft(4));
                Console.WriteLine();
            }
        }
    }
}
