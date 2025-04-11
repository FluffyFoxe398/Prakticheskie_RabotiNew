using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Stars(int n) //n – параметр метода
        {
            for (int i = 0; i < n; i++) //i - локальная переменная
            {
                for (int j = 0; j < n; j++) //j - локальная переменная
                    Console.Write('*');
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Stars(Convert.ToInt32(Console.ReadLine()));
            Console.ReadKey();
        }
    }
}
