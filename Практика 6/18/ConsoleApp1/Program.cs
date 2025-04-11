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
            Console.Write("Введите длину массива n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[n];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
                array[i] = rnd.Next(0, 20);

            Console.WriteLine("Исходный массив:");
            foreach (var item in array)
                Console.Write(item + " ");
            Console.WriteLine();

            List<int> unique = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < array.Length; j++)
                    if (array[i] == array[j]) count++;

                if (count == 1)
                    unique.Add(array[i]);
            }

            Console.WriteLine("Уникальные элементы:");
            foreach (var item in unique)
                Console.Write(item + " ");

            Console.ReadKey();
        }
    }
}
