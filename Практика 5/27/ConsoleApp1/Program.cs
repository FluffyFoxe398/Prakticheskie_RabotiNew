using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static int Min(int a, int b)
        {
            return (a < b) ? a : b;
        }

        static double Min(double a, double b)
        {
            return (a < b) ? a : b;
        }

        static void Main()
        {
            Console.WriteLine("Работа с int:");
            Console.Write("Введите первое число: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Минимум (int): {Min(x, y)}");

            Console.WriteLine("\nРабота с double:");
            Console.Write("Введите первое число: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе число: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Минимум (double): {Min(a, b)}");

            Console.ReadKey();
        }
    }
}
