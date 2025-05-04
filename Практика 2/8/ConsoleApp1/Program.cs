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
            Console.WriteLine("Введите число:");
            string input = Console.ReadLine();

            if (double.TryParse(input, out double number))
            {
                Console.WriteLine($"Вы ввели число: {number}");
            }
            else
            {
                Console.WriteLine("Ошибка! Введённые данные не являются числом.");
            }
        }

    }
}
