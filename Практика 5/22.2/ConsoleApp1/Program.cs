using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static double AreaOnYear(int n)
        {
            double area = 100; // в гектарах

            for (int i = 1; i < n; i++)
            {
                area *= 1.05; // +5% каждый год
            }

            return area;
        }

        static void Main()
        {
            Console.Write("Введите номер года (N): ");
            int n = Convert.ToInt32(Console.ReadLine());

            double result = AreaOnYear(n);
            Console.WriteLine($"Площадь на {n}-й год: {result:F2} га");

            Console.ReadKey();
        }
    }
}
