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
            Console.WriteLine("Задание 5и: Каждое из чисел X, Y, Z отрицательное");
            Console.Write("Введите число X: ");
            double X = double.Parse(Console.ReadLine());
            Console.Write("Введите число Y: ");
            double Y = double.Parse(Console.ReadLine());
            Console.Write("Введите число Z: ");
            double Z = double.Parse(Console.ReadLine());

            bool result = X < 0 && Y < 0 && Z < 0;
            Console.WriteLine($"Каждое из чисел {X}, {Y}, {Z} отрицательное: {result}");
        }


    }
}
