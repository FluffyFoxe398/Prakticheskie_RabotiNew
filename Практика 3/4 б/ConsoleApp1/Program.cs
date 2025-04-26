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
            Console.WriteLine("Задание 4б: неверно, что x < 2");
            Console.Write("Введите число x: ");
            double x = double.Parse(Console.ReadLine());

            bool result = !(x < 2);
            Console.WriteLine($"неверно, что {x} < 2 = {result}");
        }


    }
}
