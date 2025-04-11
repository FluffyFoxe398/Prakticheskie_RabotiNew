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
            int[] array = new int[10];
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
                array[i] = rnd.Next(1, 100);

            Console.Write("Введите m (на сколько сдвинуть): ");
            int m = Convert.ToInt32(Console.ReadLine());
            m = m % array.Length;

            Console.WriteLine("Оригинальный массив:");
            foreach (var item in array)
                Console.Write(item + " ");

            int[] shifted = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                shifted[(i + m) % array.Length] = array[i];
            }

            Console.WriteLine("\nМассив после сдвига:");
            foreach (var item in shifted)
                Console.Write(item + " ");

            Console.ReadKey();
        }
    }
}
