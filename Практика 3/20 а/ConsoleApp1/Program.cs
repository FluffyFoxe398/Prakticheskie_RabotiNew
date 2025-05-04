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
            Console.WriteLine("Определение выходного дня в году (1 января - понедельник)");

            int k;
            do
            {
                Console.Write("Введите день года (1-365): ");
                k = int.Parse(Console.ReadLine());
            } while (k < 1 || k > 365);

            // Определяем день недели (0-пн, 1-вт, ..., 5-сб, 6-вс)
            int dayOfWeek = (k - 1) % 7;

            bool isWeekend = dayOfWeek >= 5; // 5 или 6 - выходные
            string dayName = GetDayName(dayOfWeek);

            Console.WriteLine($"\n{k}-й день года - {dayName}");
            Console.WriteLine($"Это {(isWeekend ? "выходной" : "рабочий")} день");
        }

        static string GetDayName(int dayIndex)
        {
            return dayIndex switch
            {
                0 => "понедельник",
                1 => "вторник",
                2 => "среда",
                3 => "четверг",
                4 => "пятница",
                5 => "суббота",
                6 => "воскресенье",
                _ => throw new ArgumentException()
            };
        }


    }
}
