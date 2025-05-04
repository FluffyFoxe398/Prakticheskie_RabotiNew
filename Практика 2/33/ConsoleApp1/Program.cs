using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int a, b, c;
            a = b = c = 2;
            double z = a * b + (double)c++ / b - a * b * --c;
            Console.WriteLine("z = " + z);
            // double z = a / 3;
        }

    }
}
