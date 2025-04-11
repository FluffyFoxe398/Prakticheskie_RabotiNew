using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void PrintArray(Array array)
        {
            foreach (var item in array)
                Console.Write(item + " ");
            Console.WriteLine();
        }

        static int[] CreateArray(int length = 10, int min = 1, int max = 99)
        {
            int[] arr = new int[length];
            Random rnd = new Random();

            for (int i = 0; i < arr.Length; i++)
                arr[i] = rnd.Next(min, max + 1);

            return arr;
        }

        static int SumEven(int[] array)
        {
            int sum = 0;
            foreach (var item in array)
            {
                if (item % 2 == 0)
                    sum += item;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            int[] array = CreateArray();
            PrintArray(array);

            int sum = SumEven(array);
            Console.WriteLine("Сумма чётных элементов: " + sum);

            Console.ReadKey();
        }
    }
}
