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
            Console.WriteLine("Задание 5е: Каждое из чисел X и Y нечетное");
            Console.Write("Введите число X (целое): ");
            int X = int.Parse(Console.ReadLine());
            Console.Write("Введите число Y (целое): ");
            int Y = int.Parse(Console.ReadLine());

            bool result = X % 2 != 0 && Y % 2 != 0;
            Console.WriteLine($"Каждое из чисел {X} и {Y} нечетное: {result}");
        }


    }
}
