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
            Console.WriteLine("Задание 6а: Кратно ли число A двум или трём?");
            Console.Write("Введите целое число A: ");
            int A = int.Parse(Console.ReadLine());

            bool result = (A % 2 == 0) || (A % 3 == 0);
            Console.WriteLine($"Число {A} кратно 2 или 3: {result}");
        }


    }
}
