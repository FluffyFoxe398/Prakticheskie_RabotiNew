using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Print(int[] array)
        {
            Console.WriteLine("Одномерный массив:");
            foreach (var item in array)
                Console.Write(item + " ");
            Console.WriteLine();
        }

        static void Print(int[,] matrix)
        {
            Console.WriteLine("Двумерный массив:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write(matrix[i, j].ToString().PadLeft(4));
                Console.WriteLine();
            }
        }

        static void Main()
        {
            int[] array1D = { 1, 2, 3, 4, 5 };
            int[,] array2D = {
            { 1, 2, 3 },
            { 4, 5, 6 }
        };

            Print(array1D);
            Print(array2D);

            Console.ReadKey();
        }
    }
}
