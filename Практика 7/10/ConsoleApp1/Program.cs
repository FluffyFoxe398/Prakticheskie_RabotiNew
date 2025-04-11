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

            for (int i = 0; i < 5; i++)
            {
                int sum = 0;
                for (int j = 0; j < 6; j++)
                    sum += matrix[i, j];

                if (sum > maxSum)
                {
                    maxSum = sum;
                    maxIndex = i;
                }
            }

            int[] resultRow = new int[6];
            for (int j = 0; j < 6; j++)
                resultRow[j] = matrix[maxIndex, j];

            Console.WriteLine($"\nСтрока с максимальной суммой ({maxSum}):");
            foreach (var item in resultRow)
                Console.Write(item + " ");

            Console.ReadKey();
        }
    }
}
