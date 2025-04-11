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
            int[] array = new int[20];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
                array[i] = rnd.Next(0, 100);

            Console.WriteLine("Массив:");
            foreach (var item in array)
                Console.Write(item + " ");
            Console.WriteLine();

            int sumEven = 0, sumOdd = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                    sumEven += array[i];
                else
                    sumOdd += array[i];
            }

            Console.WriteLine($"Сумма с чётных индексов: {sumEven}");
            Console.WriteLine($"Сумма с нечётных индексов: {sumOdd}");

            if (sumEven > sumOdd)
                Console.WriteLine("Сумма чётных индексов больше.");
            else if (sumOdd > sumEven)
                Console.WriteLine("Сумма нечётных индексов больше.");
            else
                Console.WriteLine("Суммы равны.");

            Console.ReadKey();
        }
    }
}
