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
            int[,] matrix = new int[5, 4];
            Random rnd = new Random();

            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 4; j++)
                    matrix[i, j] = rnd.Next(0, 2); // специально, чтобы могли быть все нули

            Console.WriteLine("Исходная матрица:");
            Print(matrix);

            bool allZero = true;
            for (int j = 0; j < 4; j++)
            {
                if (matrix[4, j] != 0)
                {
                    allZero = false;
                    break;
                }
            }

            if (allZero)
                SwapRows(matrix, 4, 3); // с предпоследней
            else
                SwapRows(matrix, 4, 0); // с первой

            Console.WriteLine("\nПосле замены строк:");
            Print(matrix);

            Console.ReadKey();
        }

        static void SwapRows(int[,] matrix, int row1, int row2)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
                (matrix[row1, j], matrix[row2, j]) = (matrix[row2, j], matrix[row1, j]);
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
