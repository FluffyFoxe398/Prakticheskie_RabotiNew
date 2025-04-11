using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static double Distance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        static void Main()
        {
            Console.Write("Введите x1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите y1: ");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите x2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите y2: ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            double result = Distance(x1, y1, x2, y2);
            Console.WriteLine($"Расстояние между точками: {result:F2}");

            Console.ReadKey();
        }
    }
}
