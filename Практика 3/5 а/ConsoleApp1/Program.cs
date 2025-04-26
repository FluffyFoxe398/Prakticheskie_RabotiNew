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
            Console.WriteLine("Задание 5а: Каждое из чисел A и B больше 100");
            Console.Write("Введите число A: ");
            double A = double.Parse(Console.ReadLine());
            Console.Write("Введите число B: ");
            double B = double.Parse(Console.ReadLine());

            bool result = A > 100 && B > 100;
            Console.WriteLine($"Каждое из чисел {A} и {B} больше 100: {result}");
        }


    }
}
