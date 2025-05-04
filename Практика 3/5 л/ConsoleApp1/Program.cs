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
            Console.WriteLine("Задание 5л: Хотя бы одно из чисел X, Y, Z больше 100");
            Console.Write("Введите число X: ");
            double X = double.Parse(Console.ReadLine());
            Console.Write("Введите число Y: ");
            double Y = double.Parse(Console.ReadLine());
            Console.Write("Введите число Z: ");
            double Z = double.Parse(Console.ReadLine());

            bool result = X > 100 || Y > 100 || Z > 100;
            Console.WriteLine($"Хотя бы одно из чисел {X}, {Y}, {Z} больше 100: {result}");
        }


    }
}
