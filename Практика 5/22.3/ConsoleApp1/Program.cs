using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static double HarvestForThreeYears(int n)
        {
            double yield = 20;
            double area = 100;

            for (int i = 1; i < n; i++)
            {
                yield *= 1.02;
                area *= 1.05;
            }

            return yield * area * 3;
        }

        static void Main()
        {
            Console.Write("Введите номер года (N): ");
            int n = Convert.ToInt32(Console.ReadLine());

            double result = HarvestForThreeYears(n);
            Console.WriteLine($"Урожай за 3 года: {result:F2} ц");

            Console.ReadKey();
        }
    }
}
