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
            int[,] matrix = new int[7, 4];
            Random rnd = new Random();

            for (int i = 0; i < 7; i++)
                for (int j = 0; j < 4; j++)
                    matrix[i, j] = rnd.Next(-15, 15);

            Console.WriteLine("Матрица 7x4:");
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 4; j++)
                    Console.Write(matrix[i, j].ToString().PadLeft(4));
                Console.WriteLine();
            }

            Console.WriteLine("\nСтроки, содержащие хотя бы один нечётный отрицательный элемент:");
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (matrix[i, j] < 0 && matrix[i, j] % 2 != 0)
                    {
                        Console.WriteLine($"Строка {i + 1}");
                        break;
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
