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
            Console.WriteLine("Задание 5в: Каждое из чисел A, B, C кратно трём");
            Console.Write("Введите число A: ");
            double A = double.Parse(Console.ReadLine());
            Console.Write("Введите число B: ");
            double B = double.Parse(Console.ReadLine());
            Console.Write("Введите число C: ");
            double C = double.Parse(Console.ReadLine());

            bool result = A % 3 == 0 && B % 3 == 0 && C % 3 == 0;
            Console.WriteLine($"Каждое из чисел {A}, {B}, {C} кратно трём: {result}");
        }


    }
}
