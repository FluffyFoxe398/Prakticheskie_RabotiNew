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
            Random rnd = new Random(); // Создаём экземпляр класса Random

            // Выводим случайное число от 0 до +∞ (фактически до Int32.MaxValue)
            Console.WriteLine("Случайное число от 0 до +∞: " + rnd.Next());

            // Выводим случайное число от 0 до 5 (не включая 5)
            Console.WriteLine("Случайное число от 0 до 5: " + rnd.Next(5));

            // Выводим случайное число от -5 до 5 (не включая 5)
            Console.WriteLine("Случайное число от -5 до 5: " + rnd.Next(-5, 5));
        }

    }
}
