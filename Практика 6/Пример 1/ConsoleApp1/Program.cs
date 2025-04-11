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

        static void Main(string[] args)
        {
            int n = 50;
            int[] array = new int[n];
            int k = 0;

            for (int i = 0; i < n; i++)
            {
                array[i] = k + 2;
                k += 2;
            }

            PrintArray(array);

            Console.ReadKey();
        }
    }
}
