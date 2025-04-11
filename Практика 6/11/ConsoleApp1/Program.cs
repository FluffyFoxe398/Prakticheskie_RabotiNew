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
            int[] array = new int[18];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
                array[i] = rnd.Next(-100, 101);

            Console.WriteLine("Массив:");
            foreach (var item in array)
                Console.Write(item + " ");
            Console.WriteLine();

            int min = array[0];
            for (int i = 2; i < array.Length; i += 2)
            {
                if (array[i] < min)
                    min = array[i];
            }

            Console.WriteLine("Минимальный элемент на чётных индексах: " + min);

            Console.ReadKey();
        }
    }
}
