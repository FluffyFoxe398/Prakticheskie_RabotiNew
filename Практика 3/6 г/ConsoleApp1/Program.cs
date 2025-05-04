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
            Console.WriteLine("Задание 6г: Кратно ли N четырём и не оканчивается на 0?");
            Console.Write("Введите целое число N: ");
            int N = int.Parse(Console.ReadLine());

            bool result = (N % 4 == 0) && (N % 10 != 0);
            Console.WriteLine($"Число {N} кратно 4 и не оканчивается на 0: {result}");
        }


    }
}
