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
            int[,] matrix = new int[15, 9];
            Random rnd = new Random();

            for (int i = 0; i < 15; i++)
                for (int j = 0; j < 9; j++)
                    matrix[i, j] = rnd.Next(0, 100);

            Console.WriteLine("Матрица 15x9:");
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 9; j++)
                    Console.Write(matrix[i, j].ToString().PadLeft(4));
                Console.WriteLine();
            }

            Console.WriteLine("\nМинимальные элементы по строкам:");
            for (int i = 0; i < 15; i++)
            {
                int min = matrix[i, 0];
                for (int j = 1; j < 9; j++)
                    if (matrix[i, j] < min)
                        min = matrix[i, j];
                Console.WriteLine($"Строка {i + 1}: {min}");
            }

            Console.ReadKey();
        }
    }
}
