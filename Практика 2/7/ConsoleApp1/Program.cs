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
            // Получаем число e из библиотеки Math
            double e = Math.E;

            // Округляем до десятых (1 знак после запятой)
            double roundedE = Math.Round(e, 1);

            Console.WriteLine($"Точное значение e: {e}");
            Console.WriteLine($"Округлённое до десятых: {roundedE}");

            // Альтернативный вывод с форматированием
            Console.WriteLine($"Форматированный вывод: {e:F1}");  // F1 - 1 знак после запятой
        }

    }
}
