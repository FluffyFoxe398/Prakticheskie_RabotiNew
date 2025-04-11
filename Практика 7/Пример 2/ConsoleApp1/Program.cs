using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void PrintMatrix(int[,] array)
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

        static void PrintArray(int[] array)
        {
            foreach (var item in array)
                Console.Write(item + " ");
            Console.WriteLine();
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

        static int[] MainDiagonal(int[,] array)
        {
            int size = Math.Min(array.GetLength(0), array.GetLength(1));
            int[] result = new int[size];

            for (int i = 0; i < size; i++)
                result[i] = array[i, i];

            return result;
        }

        static void Main()
        {
            int[,] array = CreateArray();
            Console.WriteLine("Двумерный массив:");
            PrintMatrix(array);

            int[] diagonal = MainDiagonal(array);
            Console.WriteLine("\nГлавная диагональ:");
            PrintArray(diagonal);

            Console.ReadKey();
        }
    }
}
