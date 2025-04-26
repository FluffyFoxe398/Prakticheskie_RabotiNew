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
            Console.WriteLine("Проверка взаимной делимости двух чисел");

            // Ввод данных с проверкой
            int a, b;
            while (true)
            {
                try
                {
                    Console.Write("Введите первое число (a): ");
                    a = int.Parse(Console.ReadLine());
                    Console.Write("Введите второе число (b): ");
                    b = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Ошибка! Введите целые числа.");
                }
            }

            // Проверка делимости
            bool aDividesB = (b % a == 0) && (a != 0);
            bool bDividesA = (a % b == 0) && (b != 0);

            // Вывод результатов
            Console.WriteLine("\nРезультаты проверки:");
            Console.WriteLine($"{a} является делителем {b}: {aDividesB}");
            Console.WriteLine($"{b} является делителем {a}: {bDividesA}");

            // Дополнительная информация
            if (a == 0 && b == 0)
            {
                Console.WriteLine("\nПримечание: 0 не может быть делителем!");
            }
            else if (a == 0)
            {
                Console.WriteLine("\nПримечание: 0 не может быть делителем (первый случай)");
            }
            else if (b == 0)
            {
                Console.WriteLine("\nПримечание: 0 не может быть делителем (второй случай)");
            }
        }


    }
}
