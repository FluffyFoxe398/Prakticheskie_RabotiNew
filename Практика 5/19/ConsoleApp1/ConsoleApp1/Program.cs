using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static int MonthsToReachGoal(double deposit, double percent, double goal)
        {
            int months = 0;

            while (deposit < goal)
            {
                deposit += deposit * (percent / 100);
                months++;
            }

            return months;
        }

        static void Main()
        {
            Console.Write("Введите сумму вклада (₽): ");
            double deposit = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите процент увеличения в месяц (%): ");
            double percent = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите необходимую сумму (₽): ");
            double goal = Convert.ToDouble(Console.ReadLine());

            int months = MonthsToReachGoal(deposit, percent, goal);
            Console.WriteLine($"Необходимое количество месяцев: {months}");

            Console.ReadKey();
        }
    }
}
