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

            Console.Write("Введите значение M: ");
            int m = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = m;
            }

            Console.WriteLine("Массив:");
            foreach (int item in array)
                Console.Write(item + " ");

            Console.ReadKey();
        }
    }
}
