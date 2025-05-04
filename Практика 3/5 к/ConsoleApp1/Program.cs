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
            Console.WriteLine("Задание 5к: Только одно из чисел X, Y и Z кратно пяти");
            Console.Write("Введите число X: ");
            double X = double.Parse(Console.ReadLine());
            Console.Write("Введите число Y: ");
            double Y = double.Parse(Console.ReadLine());
            Console.Write("Введите число Z: ");
            double Z = double.Parse(Console.ReadLine());

            int count = 0;
            if (X % 5 == 0) count++;
            if (Y % 5 == 0) count++;
            if (Z % 5 == 0) count++;

            bool result = count == 1;
            Console.WriteLine($"Только одно из чисел {X}, {Y}, {Z} кратно пяти: {result}");
        }


    }
}
