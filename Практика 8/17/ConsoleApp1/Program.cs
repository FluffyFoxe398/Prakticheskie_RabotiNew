using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите выражение (например, 2+3*4): ");
            string input = Console.ReadLine();

            try
            {
                var result = new DataTable().Compute(input, null);
                Console.WriteLine($"Результат: {result}");
            }
            catch
            {
                Console.WriteLine("Ошибка при вычислении. Проверь выражение.");
            }

            Console.ReadKey();
        }
    }
}
