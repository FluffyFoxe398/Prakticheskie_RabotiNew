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
            Console.WriteLine("Задание 5г: Только одно из чисел A, B и C меньше 50");
            Console.Write("Введите число A: ");
            double A = double.Parse(Console.ReadLine());
            Console.Write("Введите число B: ");
            double B = double.Parse(Console.ReadLine());
            Console.Write("Введите число C: ");
            double C = double.Parse(Console.ReadLine());

            int count = 0;
            if (A < 50) count++;
            if (B < 50) count++;
            if (C < 50) count++;

            bool result = count == 1;
            Console.WriteLine($"Только одно из чисел {A}, {B}, {C} меньше 50: {result}");
        }


    }
}
