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
            Console.WriteLine("Расчет средних значений модулей");

            Console.Write("Введите первое число: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            double num2 = double.Parse(Console.ReadLine());

            // Модули чисел
            double abs1 = Math.Abs(num1);
            double abs2 = Math.Abs(num2);

            // Среднее арифметическое
            double avgArithmetic = (abs1 + abs2) / 2;

            // Среднее геометрическое
            double avgGeometric = Math.Sqrt(abs1 * abs2);

            Console.WriteLine($"Среднее арифметическое модулей: {avgArithmetic:F2}");
            Console.WriteLine($"Среднее геометрическое модулей: {avgGeometric:F2}");
        }

    }
}
