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
            Console.WriteLine("Определение месяца по количеству месяцев и дней с 1990 года");

            int n;
            do
            {
                Console.Write("Введите количество полных месяцев (n ≥ 0): ");
                n = int.Parse(Console.ReadLine());
            } while (n < 0);

            // Начальная дата - 1 января 1990 года (месяц 0)
            int totalMonths = n + 1; // +1 потому что прошло n месяцев и 2 дня (уже следующий месяц)

            // Определяем год и месяц
            int year = 1990 + totalMonths / 12;
            int month = totalMonths % 12;
            if (month == 0)
            {
                month = 12;
                year--;
            }

            // Получаем название месяца
            string monthName = new DateTime(year, month, 1).ToString("MMMM", new System.Globalization.CultureInfo("ru-RU"));

            Console.WriteLine($"\nПрошло {n} месяцев и 2 дня с января 1990 года");
            Console.WriteLine($"Это {monthName.ToLower()} {year} года");
        }


    }
}
