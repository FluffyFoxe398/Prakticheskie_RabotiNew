using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void PrintArray(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(array[i, j].ToString().PadLeft(4));
                }
                Console.WriteLine();
            }
        }

        static int[,] CreateArray(int rows = 5, int cols = 5, int min = 1, int max = 99)
        {
            int[,] array = new int[rows, cols];
            Random rnd = new Random();

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    array[i, j] = rnd.Next(min, max + 1);

            return array;
        }

        static void Main()
        {
            int[,] array = CreateArray();
            Console.WriteLine("Двумерный массив:");
            PrintArray(array);

            Console.ReadKey();
        }
    }
}
