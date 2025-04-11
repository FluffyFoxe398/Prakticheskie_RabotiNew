using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static double DistanceFromHome(int steps)
        {
            double distance = 0;
            int direction = 1;

            for (int i = 2; i <= steps + 1; i++)
            {
                double step = 1.0 / i;
                distance += direction * step;
                direction *= -1;
            }

            return Math.Abs(distance);
        }

        static void Main()
        {
            Console.Write("Введите количество этапов (N): ");
            int steps = Convert.ToInt32(Console.ReadLine());

            double result = DistanceFromHome(steps);
            Console.WriteLine($"Расстояние от дома: {result:F4} км");

            Console.ReadKey();
        }
    }
}
