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
            Console.WriteLine("Определение предыдущего дня (не високосный год)");

            // Ввод данных с проверкой
            int m, n;
            do
            {
                Console.Write("Введите номер месяца (1-12): ");
                m = int.Parse(Console.ReadLine());
                Console.Write("Введите число (1-31): ");
                n = int.Parse(Console.ReadLine());

                // Проверка, что это не 1 января
                if (m == 1 && n == 1)
                    Console.WriteLine("Ошибка: это 1 января! Введите другую дату.");

            } while (m < 1 || m > 12 || n < 1 || n > 31 || (m == 1 && n == 1));

            // Количество дней в каждом месяце (не високосный год)
            int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            // Определение предыдущего дня
            int prevDay = n - 1;
            int prevMonth = m;
            int prevYear = 2023; // пример года

            if (prevDay < 1)
            {
                prevMonth--;
                if (prevMonth < 1)
                {
                    prevMonth = 12;
                    prevYear--;
                }
                prevDay = daysInMonth[prevMonth - 1];
            }

            // Получение названия месяца
            string monthName = new DateTime(prevYear, prevMonth, 1).ToString("MMMM", new System.Globalization.CultureInfo("ru-RU"));

            Console.WriteLine($"\nПредыдущий день: {prevDay} {monthName.ToLower()}");
        }


    }
}
