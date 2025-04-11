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
            int[,] matrix = new int[5, 10];
            Random rnd = new Random();

            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 10; j++)
                    matrix[i, j] = rnd.Next(-5, 20);

            Console.WriteLine("Матрица 5x10:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                    Console.Write(matrix[i, j].ToString().PadLeft(4));
                Console.WriteLine();
            }

            Console.WriteLine("\nСтроки, содержащие только положительные элементы:");
            for (int i = 0; i < 5; i++)
            {
                bool allPositive = true;
                for (int j = 0; j < 10; j++)
                {
                    if (matrix[i, j] <= 0)
                    {
                        allPositive = false;
                        break;
                    }
                }

                if (allPositive)
                    Console.WriteLine($"Строка {i + 1}");
            }

            Console.ReadKey();
        }
    }
}
