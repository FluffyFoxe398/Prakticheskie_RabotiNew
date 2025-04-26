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
            Console.WriteLine("Расчет площади кольца");

            Console.Write("Введите внешний радиус R: ");
            double R = double.Parse(Console.ReadLine());

            Console.Write("Введите внутренний радиус r: ");
            double r = double.Parse(Console.ReadLine());

            if (R <= r)
            {
                Console.WriteLine("Ошибка: внешний радиус должен быть больше внутреннего");
            }
            else
            {
                double S = Math.PI * (Math.Pow(R, 2) - Math.Pow(r, 2));
                Console.WriteLine($"Площадь кольца: {S:F2}");
            }
        }

    }
}
