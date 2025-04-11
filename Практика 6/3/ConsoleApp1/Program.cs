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

            // Заполнение массива случайными числами от -50 до 50
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-50, 51);
            }

            int sum = 0;
            for (int i = 1; i < array.Length; i += 2)
            {
                if (array[i] < 0)
                    sum += array[i];
            }

            Console.WriteLine("Массив:");
            foreach (int item in array)
                Console.Write(item + " ");

            Console.WriteLine("\nСумма отрицательных элементов на нечётных индексах: " + sum);

            Console.ReadKey();
        }
    }
}
