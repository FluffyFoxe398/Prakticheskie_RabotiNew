using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static int Digits(int n) //n - параметр метода
        {
            int count = 0; //count - локальная переменная
            while (n > 0)
            {
                n /= 10;
                count++;
            }
            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Digits(Convert.ToInt32(Console.ReadLine()));
            Console.ReadKey();
        }
    }
}
