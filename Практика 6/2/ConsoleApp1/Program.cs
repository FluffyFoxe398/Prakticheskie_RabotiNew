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
            Console.Write("Введите длину массива: ");
            int n = Convert.ToInt32(Console.ReadLine());

            double[] array = new double[n];
            double sum = 0;
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введите элемент {i + 1}: ");
                array[i] = Convert.ToDouble(Console.ReadLine());

                if (array[i] > 0)
                {
                    sum += array[i];
                    count++;
                }
            }

            double average = count > 0 ? sum / count : 0;

            Console.WriteLine("Среднее положительных элементов: " + average);

            Console.ReadKey();
        }
    }
}
