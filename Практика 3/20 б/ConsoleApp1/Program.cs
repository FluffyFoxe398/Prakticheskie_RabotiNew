using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Нахождение max и min (один тернарный оператор)");

            Console.Write("Введите первое число: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            double b = double.Parse(Console.ReadLine());

            double max = a > b ? a : b;
            double min = a < b ? a : b;

            Console.WriteLine($"\nМаксимальное: {max}");
            Console.WriteLine($"Минимальное: {min}");
        }


    }
}
