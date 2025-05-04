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
            Console.WriteLine("Определение достоинства карты");

            int k;
            do
            {
                Console.Write("Введите номер карты (6-14): ");
                k = int.Parse(Console.ReadLine());
            } while (k < 6 || k > 14);

            string cardName = k switch
            {
                11 => "валет",
                12 => "дама",
                13 => "король",
                14 => "туз",
                _ => k.ToString() // Для номеров 6-10
            };

            Console.WriteLine($"\nКарта с номером {k} - это {cardName}");
        }


    }
}
