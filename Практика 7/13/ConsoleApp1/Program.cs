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
            int[,] matrix = new int[8, 5];
            Random rnd = new Random();

            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 5; j++)
                    matrix[i, j] = rnd.Next(20, 41);

            Console.WriteLine("Матрица 8x5:");
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 5; j++)
                    Console.Write(matrix[i, j].ToString().PadLeft(4));
                Console.WriteLine();
            }

            Console.WriteLine("\nСтроки с не более чем 3 чётными элементами:");
            for (int i = 0; i < 8; i++)
            {
                int evenCount = 0;
                for (int j = 0; j < 5; j++)
                    if (matrix[i, j] % 2 == 0)
                        evenCount++;

                if (evenCount <= 3)
                    Console.WriteLine($"Строка {i + 1} — чётных: {evenCount}");
            }

            Console.ReadKey();
        }
    }
}
