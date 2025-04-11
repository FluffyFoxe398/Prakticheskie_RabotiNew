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
            int[,] matrix = new int[6, 5];
            Random rnd = new Random();

            for (int i = 0; i < 6; i++)
                for (int j = 0; j < 5; j++)
                    matrix[i, j] = rnd.Next(1, 30);

            Console.WriteLine("Матрица:");
            Print(matrix);

            Console.Write("Введите пороговое значение: ");
            double limit = Convert.ToDouble(Console.ReadLine());

            int count = 0;

            for (int i = 0; i < 6; i++)
            {
                double sum = 0;
                for (int j = 0; j < 5; j++)
                    sum += matrix[i, j];

                double avg = sum / 5;
                if (avg < limit)
                    count++;
            }

            Console.WriteLine($"\nКоличество строк со средним < {limit}: {count}");

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
