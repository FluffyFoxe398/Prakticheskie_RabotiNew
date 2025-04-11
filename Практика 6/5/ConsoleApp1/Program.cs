using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static int[] CreateRandomArray(int n, int min = -50, int max = 50)
        {
            int[] array = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                array[i] = rnd.Next(min, max + 1);
            return array;
        }

        static void PrintArray(int[] array)
        {
            foreach (var item in array)
                Console.Write(item + " ");
            Console.WriteLine();
        }

        static int SumEvenIndices(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i += 2)
                sum += array[i];
            return sum;
        }

        static int MinPositive(int[] array)
        {
            int min = int.MaxValue;
            bool found = false;
            foreach (var item in array)
            {
                if (item > 0 && item < min)
                {
                    min = item;
                    found = true;
                }
            }
            return found ? min : 0;
        }

        static int SumMinMax(int[] array)
        {
            int min = array[0], max = array[0];
            foreach (var item in array)
            {
                if (item < min) min = item;
                if (item > max) max = item;
            }
            return min + max;
        }

        static int CountPositive(int[] array)
        {
            int count = 0;
            foreach (var item in array)
                if (item > 0) count++;
            return count;
        }

        static int SumEvenPositivesInRange(int[] array, int a, int b)
        {
            int sum = 0;
            for (int i = a; i <= b && i < array.Length; i++)
            {
                if (array[i] > 0 && array[i] % 2 == 0)
                    sum += array[i];
            }
            return sum;
        }

        static double AverageEven(int[] array)
        {
            int sum = 0, count = 0;
            foreach (var item in array)
            {
                if (item % 2 == 0)
                {
                    sum += item;
                    count++;
                }
            }
            return count > 0 ? (double)sum / count : 0;
        }

        static int SumEvenPositives(int[] array)
        {
            int sum = 0;
            foreach (var item in array)
                if (item > 0 && item % 2 == 0)
                    sum += item;
            return sum;
        }

        static int SumNegativeEvenIndices(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i += 2)
            {
                if (array[i] < 0)
                    sum += array[i];
            }
            return sum;
        }

        static int MaxInRange(int[] array, int a, int b)
        {
            int max = array[a];
            for (int i = a; i <= b && i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
            }
            return max;
        }

        static int MinOddIndices(int[] array)
        {
            int min = int.MaxValue;
            for (int i = 1; i < array.Length; i += 2)
            {
                if (array[i] < min)
                    min = array[i];
            }
            return min;
        }

        static int MinOddInRange(int[] array, int a, int b)
        {
            int min = int.MaxValue;
            for (int i = a; i <= b && i < array.Length; i++)
            {
                if (array[i] % 2 != 0 && array[i] < min)
                    min = array[i];
            }
            return min;
        }

        static double AvgEvenIndices(int[] array)
        {
            int sum = 0, count = 0;
            for (int i = 0; i < array.Length; i += 2)
            {
                sum += array[i];
                count++;
            }
            return count > 0 ? (double)sum / count : 0;
        }

        static double AvgLessThan50(int[] array)
        {
            int sum = 0, count = 0;
            foreach (var item in array)
            {
                if (item < 50)
                {
                    sum += item;
                    count++;
                }
            }
            return count > 0 ? (double)sum / count : 0;
        }

        static void CompareSums(int[] array)
        {
            int sumEvenIndices = 0;
            int sumOddIndices = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                    sumEvenIndices += array[i];
                else
                    sumOddIndices += array[i];
            }

            if (sumEvenIndices > sumOddIndices)
                Console.WriteLine("Сумма чётных индексов больше.");
            else if (sumEvenIndices < sumOddIndices)
                Console.WriteLine("Сумма нечётных индексов больше.");
            else
                Console.WriteLine("Суммы равны.");
        }

        static void Main()
        {
            Console.Write("Введите размер массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = CreateRandomArray(n);

            Console.WriteLine("Сгенерированный массив:");
            PrintArray(array);

            Console.WriteLine("5.1 Сумма чётных индексов: " + SumEvenIndices(array));
            Console.WriteLine("5.2 Мин. положительный элемент: " + MinPositive(array));
            Console.WriteLine("5.3 Сумма мин. и макс.: " + SumMinMax(array));
            Console.WriteLine("5.4 Кол-во положительных: " + CountPositive(array));

            Console.Write("5.5 Введите a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("5.5 Введите b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Сумма чётных положительных с индексов a–b: " + SumEvenPositivesInRange(array, a, b));

            Console.WriteLine("5.6 Среднее чётных: " + AverageEven(array));
            Console.WriteLine("5.7 Сумма чётных положительных: " + SumEvenPositives(array));
            Console.WriteLine("5.8 Сумма отрицательных на чётных местах: " + SumNegativeEvenIndices(array));

            Console.Write("5.9 Введите a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("5.9 Введите b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Макс. в диапазоне: " + MaxInRange(array, a, b));

            Console.WriteLine("5.10 Мин. на нечётных индексах: " + MinOddIndices(array));

            Console.Write("5.11 Введите a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("5.11 Введите b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Мин. нечётный в диапазоне: " + MinOddInRange(array, a, b));

            Console.WriteLine("5.12 Среднее знач. чётных индексов: " + AvgEvenIndices(array));
            Console.WriteLine("5.13 Среднее знач. < 50: " + AvgLessThan50(array));

            Console.WriteLine("5.14 Сравнение сумм по чётным/нечётным индексам:");
            CompareSums(array);

            Console.ReadKey();
        }
    }
}
