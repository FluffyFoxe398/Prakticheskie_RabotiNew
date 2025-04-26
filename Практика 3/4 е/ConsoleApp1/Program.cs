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
            Console.WriteLine("Задание 4е: 10 < x < 20");
            Console.Write("Введите число x: ");
            double x = double.Parse(Console.ReadLine());

            bool result = x > 10 && x < 20;
            Console.WriteLine($"10 < {x} < 20 = {result}");
        }


    }
}
