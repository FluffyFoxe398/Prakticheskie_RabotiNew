using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            int[] n = new int[10];
            int[] m = new int[10];
            Random rnd = new Random();

            for (int i = 0; i < n.Length; i++)
                n[i] = rnd.Next(1, 21);
            for (int i = 0; i < m.Length; i++)
                m[i] = rnd.Next(1, 21);

            Console.WriteLine("Массив n:");
            foreach (var x in n) Console.Write(x + " ");
            Console.WriteLine("\nМассив m:");
            foreach (var x in m) Console.Write(x + " ");

            List<int> result = new List<int>();

            foreach (var x in n)
            {
                if (Array.IndexOf(m, x) == -1)
                    result.Add(x);
            }

            foreach (var x in m)
            {
                if (Array.IndexOf(n, x) == -1)
                    result.Add(x);
            }

            Console.WriteLine("\nЭлементы, НЕ входящие в оба массива одновременно:");
            foreach (var x in result) Console.Write(x + " ");

            Console.ReadKey();
        }
    }
}
