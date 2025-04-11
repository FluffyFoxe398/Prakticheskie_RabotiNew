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
            int[,] matrix = new int[5, 5];
            Random rnd = new Random();

            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    matrix[i, j] = rnd.Next(1, 100);

            Console.WriteLine("Исходная матрица:");
            Print(matrix);

            // Поиск max и min на главной диагонали
            int max = matrix[0, 0], min = matrix[0, 0];
            int maxIndex = 0, minIndex = 0;

            for (int i = 1; i < 5; i++)
            {
                int val = matrix[i, i];
                if (val > max)
                {
                    max = val;
                    maxIndex = i;
                }
                if (val < min)
                {
                    min = val;
                    minIndex = i;
                }
            }

            // Обмен местами
            (matrix[maxIndex, maxIndex], matrix[minIndex, minIndex]) = (matrix[minIndex, minIndex], matrix[maxIndex, maxIndex]);

            Console.WriteLine("\nМатрица после обмена min и max на диагонали:");
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
