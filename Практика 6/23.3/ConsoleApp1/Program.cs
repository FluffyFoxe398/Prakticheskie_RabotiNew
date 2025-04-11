using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static int FirstDigit(int number)
        {
            number = Math.Abs(number);
            while (number >= 10)
                number /= 10;
            return number;
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

            Array.Sort(array, (a, b) => FirstDigit(a).CompareTo(FirstDigit(b)));

            Console.WriteLine("\nСортировка по первой цифре:");
            foreach (var x in array)
                Console.Write(x + " ");

            Console.ReadKey();
        }
    }
}
