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
            Console.WriteLine("Задание 8а: Какое из двух чисел больше?");
            Console.Write("Введите первое число: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            double num2 = double.Parse(Console.ReadLine());

            if (num1 > num2)
                Console.WriteLine($"Число {num1} больше {num2}");
            else
                Console.WriteLine($"Число {num2} больше {num1}");
        }


    }
}
