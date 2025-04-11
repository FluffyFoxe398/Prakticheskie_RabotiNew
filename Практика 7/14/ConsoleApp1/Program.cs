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
                    matrix[i, j] = rnd.Next(-50, 51);

            Console.WriteLine("Матрица:");
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                    Console.Write(matrix[i, j].ToString().PadLeft(4));
                Console.WriteLine();
            }

            int minAbs = Math.Abs(matrix[0, 0]);
            int minRow = 0, minCol = 0;

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (Math.Abs(matrix[i, j]) < minAbs)
                    {
                        minAbs = Math.Abs(matrix[i, j]);
                        minRow = i;
                        minCol = j;
                    }
                }
            }

            Console.WriteLine($"\nМинимальный по модулю элемент: {matrix[minRow, minCol]}");
            Console.WriteLine($"Позиция: строка {minRow + 1}, столбец {minCol + 1}");

            Console.ReadKey();
        }
    }
}
