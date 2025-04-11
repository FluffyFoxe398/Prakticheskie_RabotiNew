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
            int[] array = new int[17];
            Random rnd = new Random();
            int sum = 0, count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-30, 31);
            }

            foreach (int item in array)
            {
                if (item > 0 && item % 2 != 0)
                {
                    sum += item;
                    count++;
                }
            }

            double average = count > 0 ? (double)sum / count : 0;

            Console.WriteLine("Массив:");
            foreach (int item in array)
                Console.Write(item + " ");

            Console.WriteLine("\nСреднее нечётных положительных: " + average);

            Console.ReadKey();
        }
    }
}
