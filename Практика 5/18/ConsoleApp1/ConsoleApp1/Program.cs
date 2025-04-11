using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static double AverageWeight(int count)
        {
            double sum = 0;

            for (int i = 1; i <= count; i++)
            {
                Console.Write($"Введите массу предмета {i} (в кг): ");
                double weight = Convert.ToDouble(Console.ReadLine());
                sum += weight;
            }

            return sum / count;
        }

        static void Main()
        {
            Console.Write("Введите количество предметов: ");
            int count = Convert.ToInt32(Console.ReadLine());

            double average = AverageWeight(count);
            Console.WriteLine("Средняя масса: " + average + " кг");

            Console.ReadKey();
        }
    }
}
