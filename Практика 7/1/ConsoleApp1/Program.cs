using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static int[,] GenerateMatrix(int rows, int cols, int min, int max)
        {
            int[,] matrix = new int[rows, cols];
            Random rnd = new Random();

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    matrix[i, j] = rnd.Next(min, max + 1);

            return matrix;
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write(matrix[i, j].ToString().PadLeft(4));
                Console.WriteLine();
            }
        }

        static void Main()
        {
            Console.Write("Введите количество строк: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите количество столбцов: ");
            int cols = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите минимальное значение A: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите максимальное значение B: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = GenerateMatrix(rows, cols, a, b);
            Console.WriteLine("\nСгенерированная матрица:");
            PrintMatrix(matrix);

            Console.ReadKey();
        }
    }
}
