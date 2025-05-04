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
            double z = (double)a * b + (double)c++ / b - a * b * --c;
            Console.WriteLine("z = " + z); // z = 1
                                           //(double)c++ /b не даст цели
                                           //z = 2,66.
                                           //double z = (a * b + (double)c) / b - a * b * --c
                                           // (4.0+2/2)-8
            a = b = c = 2;
            z = a * b + (double)c / (b) - a * b * --c;
            //z= 4 +1 - 4
            // z= 1(неверно!)

            Console.WriteLine("z = " + z);
        }

    }
}
