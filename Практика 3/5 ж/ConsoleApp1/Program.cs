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
            Console.WriteLine("Задание 5з: Хотя бы одно из чисел X и Y равно нулю");
            Console.Write("Введите число X: ");
            double X = double.Parse(Console.ReadLine());
            Console.Write("Введите число Y: ");
            double Y = double.Parse(Console.ReadLine());

            bool result = X == 0 || Y == 0;
            Console.WriteLine($"Хотя бы одно из чисел {X} и {Y} равно нулю: {result}");
        }


    }
}
