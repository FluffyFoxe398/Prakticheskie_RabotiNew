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
            Console.WriteLine("Определение сигнала светофора для пешеходов");

            double t;
            while (true)
            {
                Console.Write("Введите время в минутах (0 ≤ t < 60): ");
                if (double.TryParse(Console.ReadLine(), out t) && t >= 0 && t < 60)
                    break;
                Console.WriteLine("Ошибка! Введите число от 0 до 60 (не включая 60).");
            }

            // Определяем текущий цикл (5-минутные циклы: 3 зеленый + 2 красный)
            double cyclePosition = t % 5; // Позиция в текущем 5-минутном цикле

            string color = cyclePosition < 3 ? "зеленый" : "красный";

            Console.WriteLine($"\nВ момент времени {t} минут горит: {color}");
            Console.WriteLine($"Текущая позиция в цикле: {cyclePosition:F2} минут");

            // Дополнительная информация о времени до смены
            if (color == "зеленый")
            {
                double timeLeft = 3 - cyclePosition;
                Console.WriteLine($"До смены на красный: {timeLeft:F2} минут");
            }
            else
            {
                double timeLeft = 5 - cyclePosition;
                Console.WriteLine($"До смены на зеленый: {timeLeft:F2} минут");
            }
        }


    }
}
