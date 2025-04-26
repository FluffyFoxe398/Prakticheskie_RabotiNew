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
            double z = a * b + c++ / (double)b - a * b * --c;
            //  2*2+2/(double)2-2*2*--c
            //  =4+1-2*2*1
            // z = 1 - 4
            // z = -3
            Console.WriteLine("z = " + z);
        }

    }
}
