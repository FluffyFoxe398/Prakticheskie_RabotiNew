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

            Console.WriteLine("Оригинальный массив:");
            foreach (var item in array)
                Console.Write(item + " ");

            Console.WriteLine("\nМассив в обратном порядке:");
            for (int i = array.Length - 1; i >= 0; i--)
                Console.Write(array[i] + " ");

            Console.ReadKey();
        }
    }
}
