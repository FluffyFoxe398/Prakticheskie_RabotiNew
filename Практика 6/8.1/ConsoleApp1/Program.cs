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
            Console.Write("Введите длину ряда (n): ");
            int n = Convert.ToInt32(Console.ReadLine());

            double sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += Math.Pow(-1, i + 1) / i;
            }

            Console.WriteLine($"Сумма ряда: {sum:F4}");

            Console.ReadKey();
        }
    }
}
