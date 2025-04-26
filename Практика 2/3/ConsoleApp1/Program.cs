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
            // Исходные переменные разных типов
            float a = 3.2f;
            decimal b = 2.6m;
            double c = 4.5;

            // Явное преобразование всех чисел к double и сложение
            c = (double)a + (double)b + c;

            Console.WriteLine($"Сумма чисел: {c}");
        }

    }
}
