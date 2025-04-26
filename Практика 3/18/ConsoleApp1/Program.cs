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
            Console.WriteLine("Определение високосного года");

            int year;
            while (true)
            {
                Console.Write("Введите год (натуральное число): ");
                if (int.TryParse(Console.ReadLine(), out year) && year > 0)
                    break;
                Console.WriteLine("Ошибка! Введите целое число больше 0.");
            }

            bool isLeap = (year % 400 == 0) || (year % 100 != 0 && year % 4 == 0);

            Console.WriteLine($"\nГод {year} {(isLeap ? "високосный" : "не високосный")}");
            Console.WriteLine($"Правила:\n- Кратен 400: {year % 400 == 0}" +
                             $"\n- Кратен 100, но не 400: {year % 100 == 0 && year % 400 != 0}" +
                             $"\n- Кратен 4, но не 100: {year % 4 == 0 && year % 100 != 0}");
        }


    }
}
