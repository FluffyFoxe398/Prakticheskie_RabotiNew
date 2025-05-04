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
            Console.WriteLine("Задание 6б: Не кратно ли A трём и оканчивается на 0?");
            Console.Write("Введите целое число A: ");
            int A = int.Parse(Console.ReadLine());

            bool result = (A % 3 != 0) && (A % 10 == 0);
            Console.WriteLine($"Число {A} не кратно 3 и оканчивается на 0: {result}");
        }


    }
}
