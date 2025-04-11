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
            int[,] matrix = new int[4, 6];
            int[] rowSums = new int[4];
            Random rnd = new Random();

            // Заполнение матрицы
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 6; j++)
                    matrix[i, j] = rnd.Next(1, 20);

            // Вывод матрицы
            Console.WriteLine("Матрица 4x6:");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 6; j++)
                    Console.Write(matrix[i, j].ToString().PadLeft(4));
                Console.WriteLine();
            }

            // Вычисление суммы каждой строки
            for (int i = 0; i < 4; i++)
            {
                int sum = 0;
                for (int j = 0; j < 6; j++)
                    sum += matrix[i, j];
                rowSums[i] = sum;
            }

            // Вывод сумм строк
            Console.WriteLine("\nСуммы строк:");
            foreach (var sum in rowSums)
                Console.Write(sum + " ");

            // Поиск максимального значения среди сумм
            int maxSum = rowSums[0];
            foreach (var sum in rowSums)
                if (sum > maxSum) maxSum = sum;

            Console.WriteLine($"\nМаксимальная сумма среди строк: {maxSum}");

            Console.ReadKey();
        }
    }
}
