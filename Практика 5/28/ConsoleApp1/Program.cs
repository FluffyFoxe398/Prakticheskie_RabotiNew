using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Print(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        static void Print(string s)
        {
            Console.WriteLine(s);
        }

        static void Main()
        {
            Console.WriteLine("Печать звёздочек:");
            Console.Write("Введите количество звёздочек: ");
            int count = Convert.ToInt32(Console.ReadLine());
            Print(count);

            Console.WriteLine("\nПечать строки:");
            Console.Write("Введите строку: ");
            string text = Console.ReadLine();
            Print(text);

            Console.ReadKey();
        }
    }
}
