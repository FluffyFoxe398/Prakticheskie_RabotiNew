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
            Console.WriteLine("Определение полного названия карты");

            // Ввод номера масти с проверкой
            int m;
            do
            {
                Console.Write("Введите номер масти (1-4):\n" +
                            "1 - пики\n2 - трефы\n3 - бубны\n4 - червы\n> ");
                m = int.Parse(Console.ReadLine());
            } while (m < 1 || m > 4);

            // Ввод номера достоинства с проверкой
            int k;
            do
            {
                Console.Write("\nВведите номер достоинства (6-14):\n" +
                            "6-10 - соответствующие числа\n11 - валет\n12 - дама\n" +
                            "13 - король\n14 - туз\n> ");
                k = int.Parse(Console.ReadLine());
            } while (k < 6 || k > 14);

            // Определение масти
            string suit = m switch
            {
                1 => "пик",
                2 => "треф",
                3 => "бубен",
                4 => "червей",
                _ => throw new Exception("Недопустимая масть")
            };

            // Определение достоинства
            string rank = k switch
            {
                11 => "валет",
                12 => "дама",
                13 => "король",
                14 => "туз",
                _ => k.ToString() + "ка" // Для 6-10: "шестерка", "семерка" и т.д.
            };

            // Склонение для числительных (6-10)
            if (k >= 6 && k <= 10)
            {
                rank = k switch
                {
                    6 => "шестерка",
                    7 => "семерка",
                    8 => "восьмерка",
                    9 => "девятка",
                    10 => "десятка",
                    _ => rank
                };
            }

            // Формирование результата
            string fullName = $"{rank.First().ToString().ToUpper()}{rank.Substring(1)} {suit}";

            Console.WriteLine($"\nПолное название карты: {fullName}");
        }


    }
}
