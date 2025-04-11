using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static double AlternatingSeries(int n)
        {
            double sum = 0;
            double a = 1;
            for (int i = 1; i <= n - 1; i++)
            {
                a = a * i / (i + 1) * (-1);
                sum += a;
            }
            return sum;
        }

        static void Main()
        {
            Console.Write("Введите n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            double result = AlternatingSeries(n);
            Console.WriteLine("Сумма ряда: " + result);

            Console.ReadKey();
        }
    }
}
