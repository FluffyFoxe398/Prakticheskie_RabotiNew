using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static int LastDigit(int number)
        {
            return Math.Abs(number % 10);
        }

        static void Main()
        {
            int[] array = new int[10];
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
                array[i] = rnd.Next(10, 1000);

            Console.WriteLine("Исходный массив:");
            foreach (var x in array)
                Console.Write(x + " ");

            Array.Sort(array, (a, b) => LastDigit(a).CompareTo(LastDigit(b)));

            Console.WriteLine("\nСортировка по последней цифре:");
            foreach (var x in array)
                Console.Write(x + " ");

            Console.ReadKey();
        }
    }
}
