using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static int InputInRange()
        {
            int number;
            do
            {
                Console.Write("Введите число от 1 до 100: ");
                number = Convert.ToInt32(Console.ReadLine());
            } while (number < 1 || number > 100);

            return number;
        }

        static void Main()
        {
            int result = InputInRange();
            Console.WriteLine("Вы ввели корректное число: " + result);

            Console.ReadKey();
        }
    }
}
