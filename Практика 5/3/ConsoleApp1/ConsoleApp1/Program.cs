using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static int Min(int n1, int n2) => n1 < n2 ? n1 : n2;
        static int Min(int n1, int n2, int n3)
        {
            int min = n1;
            if (min > n2)
                min = n2;
            if (min > n3)
                min = n3;
            return min;
        }
        static int Min(int n1, int n2, int n3, int n4)
        {
            int min = n1;
            if (min > n2)
                min = n2;
            if (min > n3)
                min = n3;
            if (min > n4)
                min = n4;
            return min;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Min(1, 2));
            Console.WriteLine(Min(1, 2, 4));
            Console.WriteLine(Min(5, 6, 7, 8));
            Console.ReadKey();
        }
    }
}
