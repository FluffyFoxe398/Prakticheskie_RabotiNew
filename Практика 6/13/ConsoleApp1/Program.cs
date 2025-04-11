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
                array[i] = rnd.Next(1, 101);

            Console.WriteLine("Массив:");
            foreach (var item in array)
                Console.Write(item + " ");
            Console.WriteLine();

            int sum = 0, count = 0;
            foreach (var item in array)
            {
                if (item <= 50)
                {
                    sum += item;
                    count++;
                }
            }

            double average = count > 0 ? (double)sum / count : 0;
            Console.WriteLine("Среднее значение элементов ≤ 50: " + average.ToString("F2"));

            Console.ReadKey();
        }
    }
}
