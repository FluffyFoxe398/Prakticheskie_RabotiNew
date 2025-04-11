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
            int[,] matrix = new int[5, 6];
            Random rnd = new Random();

            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 6; j++)
                    matrix[i, j] = rnd.Next(1, 20);

            Console.WriteLine("Матрица:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                    Console.Write(matrix[i, j].ToString().PadLeft(4));
                Console.WriteLine();
            }

            int maxSum = 0;
            int maxIndex = 0;

            for (int j = 0; j < 6; j++)
            {
                int sum = 0;
                for (int i = 0; i < 5; i++)
                    sum += matrix[i, j];

                if (sum > maxSum)
                {
                    maxSum = sum;
                    maxIndex = j;
                }
            }

            int[] resultCol = new int[5];
            for (int i = 0; i < 5; i++)
                resultCol[i] = matrix[i, maxIndex];

            Console.WriteLine($"\nСтолбец с максимальной суммой ({maxSum}):");
            foreach (var item in resultCol)
                Console.Write(item + " ");

            Console.ReadKey();
        }
    }
}
