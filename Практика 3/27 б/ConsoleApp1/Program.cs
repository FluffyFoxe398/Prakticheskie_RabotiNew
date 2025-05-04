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
            Console.WriteLine("Определение следующего дня (не високосный год)");

            // Ввод данных с проверкой
            int m, n;
            do
            {
                Console.Write("Введите номер месяца (1-12): ");
                m = int.Parse(Console.ReadLine());
                Console.Write("Введите число (1-31): ");
                n = int.Parse(Console.ReadLine());

                // Проверка, что это не 31 декабря
                if (m == 12 && n == 31)
                    Console.WriteLine("Ошибка: это 31 декабря! Введите другую дату.");

            } while (m < 1 || m > 12 || n < 1 || n > 31 || (m == 12 && n == 31));

            // Количество дней в каждом месяце (не високосный год)
            int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            // Определение следующего дня
            int nextDay = n + 1;
            int nextMonth = m;
            int nextYear = 2023; // пример года

            if (nextDay > daysInMonth[m - 1])
            {
                nextDay = 1;
                nextMonth++;
                if (nextMonth > 12)
                {
                    nextMonth = 1;
                    nextYear++;
                }
            }

            // Получение названия месяца
            string monthName = new DateTime(nextYear, nextMonth, 1).ToString("MMMM", new System.Globalization.CultureInfo("ru-RU"));

            Console.WriteLine($"\nСледующий день: {nextDay} {monthName.ToLower()}");
        }


    }
}
