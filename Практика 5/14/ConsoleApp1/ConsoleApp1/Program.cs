using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static string ConvertToBase(int number, int targetBase)
        {
            if (targetBase < 2 || targetBase > 10)
                return "Основание должно быть от 2 до 10";

            string result = "";
            while (number > 0)
            {
                result = (number % targetBase) + result;
                number /= targetBase;
            }
            return result;
        }

        static void Main()
        {
            Console.Write("Введите число в 10-й системе: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите систему счисления (от 2 до 10): ");
            int baseNum = Convert.ToInt32(Console.ReadLine());

            string converted = ConvertToBase(number, baseNum);
            Console.WriteLine("Результат перевода: " + converted);

            Console.ReadKey();
        }
    }
}
