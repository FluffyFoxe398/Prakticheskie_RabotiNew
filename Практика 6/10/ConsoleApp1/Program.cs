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
            int[] array = new int[15];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
                array[i] = rnd.Next(-50, 51);

            Console.WriteLine("Массив:");
            foreach (var item in array)
                Console.Write(item + " ");
            Console.WriteLine();

            int max = array[1]; // начинаем с первого нечётного индекса
            for (int i = 3; i < array.Length; i += 2)
            {
                if (array[i] > max)
                    max = array[i];
            }

            Console.WriteLine("Максимальный элемент на нечётных индексах: " + max);

            Console.ReadKey();
        }
    }
}
