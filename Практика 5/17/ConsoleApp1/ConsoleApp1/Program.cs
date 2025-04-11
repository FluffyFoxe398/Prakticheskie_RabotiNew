using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static double AverageGrade()
        {
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Введите оценку за предмет {i}: ");
                int grade = Convert.ToInt32(Console.ReadLine());
                sum += grade;
            }

            return (double)sum / 10;
        }

        static void Main()
        {
            double average = AverageGrade();
            Console.WriteLine("Средняя оценка: " + average);

            Console.ReadKey();
        }
    }
}
