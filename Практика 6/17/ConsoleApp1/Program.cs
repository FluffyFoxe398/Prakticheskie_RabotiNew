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
                array[i] = rnd.Next(10, 40); // чтобы было больше шансов на < 20 и > 20

            Console.WriteLine("Исходный массив:");
            foreach (var item in array)
                Console.Write(item + " ");
            Console.WriteLine();

            int count = 0;
            while (count < n && array[count] < 20)
                count++;

            int[] result = new int[count];
            for (int i = 0; i < count; i++)
                result[i] = array[i];

            Console.WriteLine("Новый массив (до первого >= 20):");
            foreach (var item in result)
                Console.Write(item + " ");

            Console.ReadKey();
        }
    }
}
