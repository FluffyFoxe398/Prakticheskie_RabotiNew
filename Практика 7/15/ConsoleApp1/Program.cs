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
            int[,] matrix = new int[4, 6];
            Random rnd = new Random();

            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 6; j++)
                    matrix[i, j] = rnd.Next(0, 20);

            Console.WriteLine("Исходная матрица:");
            Print(matrix);

            Console.Write("Введите начало интервала a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите конец интервала b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 4; i++)
            {
                int[] row = new int[6];
                int index = 0;

                for (int j = 0; j < 6; j++)
                {
                    if (matrix[i, j] < a || matrix[i, j] > b)
                    {
                        row[index++] = matrix[i, j];
                    }
                }

                for (int j = 0; j < 6; j++)
                    matrix[i, j] = row[j];
            }

            Console.WriteLine("\nСжатая матрица:");
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
