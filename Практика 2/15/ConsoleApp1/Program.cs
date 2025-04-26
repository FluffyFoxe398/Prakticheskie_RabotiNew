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
            Console.WriteLine("Введите массу тела (кг):");
            double m = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите объем тела (м³):");
            double V = double.Parse(Console.ReadLine());

            double p = m / V;
            Console.WriteLine($"Плотность материала: {p} кг/м³");
        }

    }
}
