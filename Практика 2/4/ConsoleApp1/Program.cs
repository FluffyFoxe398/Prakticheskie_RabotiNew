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
            int a = 3;
            double b = 2.6;

            // Неявное преобразование int -> double при сложении
            b = a + b; // Результат автоматически преобразуется в double

            Console.WriteLine($"Сумма чисел: {b}");
        }

    }
}
