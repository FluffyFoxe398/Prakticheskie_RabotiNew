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
            int[] array = new int[20];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
                array[i] = rnd.Next(1, 101);

            Console.WriteLine("Массив:");
            foreach (var num in array)
                Console.Write(num + " ");
            Console.WriteLine();

            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0 && array[i] % 2 == 0) // чётная позиция и чётное значение
                    sum += array[i];
            }

            Console.WriteLine("Сумма элементов на чётных позициях с чётным значением: " + sum);

            Console.ReadKey();
        }
    }
}
