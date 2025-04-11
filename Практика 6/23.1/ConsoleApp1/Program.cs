using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static int SumOfDigits(int number)
        {
            int sum = 0;
            number = Math.Abs(number);
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
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

            Array.Sort(array, (a, b) => SumOfDigits(a).CompareTo(SumOfDigits(b)));

            Console.WriteLine("\nСортировка по сумме цифр:");
            foreach (var x in array)
                Console.Write(x + " ");

            Console.ReadKey();
        }
    }
}
