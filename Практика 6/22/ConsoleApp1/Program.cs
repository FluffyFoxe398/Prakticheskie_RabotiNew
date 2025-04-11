using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        (array[j], array[j + 1]) = (array[j + 1], array[j]);
                    }
                }
            }
        }

        static void SelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[minIndex])
                        minIndex = j;
                }
                (array[i], array[minIndex]) = (array[minIndex], array[i]);
            }
        }

        static void QuickSort(int[] array, int left, int right)
        {
            if (left >= right) return;

            int pivot = array[(left + right) / 2];
            int i = left, j = right;

            while (i <= j)
            {
                while (array[i] < pivot) i++;
                while (array[j] > pivot) j--;

                if (i <= j)
                {
                    (array[i], array[j]) = (array[j], array[i]);
                    i++;
                    j--;
                }
            }

            QuickSort(array, left, j);
            QuickSort(array, i, right);
        }

        static void Main()
        {
            int[] array = new int[10];
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
                array[i] = rnd.Next(1, 100);

            Console.WriteLine("Исходный массив:");
            foreach (var item in array)
                Console.Write(item + " ");

            // Копии для разных сортировок
            int[] arrBubble = (int[])array.Clone();
            int[] arrSelect = (int[])array.Clone();
            int[] arrQuick = (int[])array.Clone();

            BubbleSort(arrBubble);
            SelectionSort(arrSelect);
            QuickSort(arrQuick, 0, arrQuick.Length - 1);

            Console.WriteLine("\nСортировка пузырьком:");
            foreach (var item in arrBubble)
                Console.Write(item + " ");

            Console.WriteLine("\nСортировка выбором:");
            foreach (var item in arrSelect)
                Console.Write(item + " ");

            Console.WriteLine("\nБыстрая сортировка:");
            foreach (var item in arrQuick)
                Console.Write(item + " ");

            Console.ReadKey();
        }
    }
}
