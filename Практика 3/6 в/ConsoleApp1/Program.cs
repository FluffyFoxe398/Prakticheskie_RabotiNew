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
            Console.WriteLine("Задание 6в: Кратно ли число N пяти или семи?");
            Console.Write("Введите целое число N: ");
            int N = int.Parse(Console.ReadLine());

            bool result = (N % 5 == 0) || (N % 7 == 0);
            Console.WriteLine($"Число {N} кратно 5 или 7: {result}");
        }


    }
}
