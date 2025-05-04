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
            Console.WriteLine("Определение дня недели (1 января - заданный день)");

            int k, d;
            do
            {
                Console.Write("Введите день года (1-365): ");
                k = int.Parse(Console.ReadLine());
                Console.Write("Введите номер дня недели 1 января (1-7): ");
                d = int.Parse(Console.ReadLine());
            } while (k < 1 || k > 365 || d < 1 || d > 7);

            int dayOfWeek = (k - 1 + d - 1) % 7; // 0-пн, 1-вт, ..., 6-вс

            string dayName = dayOfWeek switch
            {
                0 => "понедельник",
                1 => "вторник",
                2 => "среда",
                3 => "четверг",
                4 => "пятница",
                5 => "суббота",
                6 => "воскресенье",
                _ => "ошибка"
            };

            Console.WriteLine($"\n{k}-й день года - это {dayName}");
        }

    }
}
