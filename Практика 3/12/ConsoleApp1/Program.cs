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
            Console.WriteLine("Сравнение расстояний: километры vs футы");

            // Ввод данных
            Console.Write("Введите расстояние в километрах: ");
            double km = double.Parse(Console.ReadLine());
            Console.Write("Введите расстояние в футах: ");
            double feet = double.Parse(Console.ReadLine());

            // Конвертация футов в километры (1 фут = 0.0003048 км)
            double feetToKm = feet * 0.0003048;

            // Сравнение с выводом результата
            Console.WriteLine("\nРезультат сравнения:");
            if (km < feetToKm)
            {
                Console.WriteLine($"{km} км < {feet} футов");
                Console.WriteLine($"({feet} футов = {feetToKm:F6} км)");
            }
            else if (km > feetToKm)
            {
                Console.WriteLine($"{km} км > {feet} футов");
                Console.WriteLine($"({feet} футов = {feetToKm:F6} км)");
            }
            else
            {
                Console.WriteLine("Расстояния равны!");
                Console.WriteLine($"({feet} футов = {feetToKm:F6} км)");
            }
        }


    }
}
