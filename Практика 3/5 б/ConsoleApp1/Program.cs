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
            Console.WriteLine("Задание 5б: Хотя бы одно из чисел A и B положительное");
            Console.Write("Введите число A: ");
            double A = double.Parse(Console.ReadLine());
            Console.Write("Введите число B: ");
            double B = double.Parse(Console.ReadLine());

            bool result = A > 0 || B > 0;
            Console.WriteLine($"Хотя бы одно из чисел {A} и {B} положительное: {result}");
        }


    }
}
