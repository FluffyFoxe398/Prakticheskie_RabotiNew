using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public struct Rectangle { /* как в 17а */ }

        public static void Main()
        {
            Console.WriteLine("17в: Проверка пересечения прямоугольников");

            Rectangle rect1 = InputRectangle("первого");
            Rectangle rect2 = InputRectangle("второго");

            bool intersects = rect1.X < rect2.Right &&
                              rect1.Right > rect2.X &&
                              rect1.Y < rect2.Top &&
                              rect1.Top > rect2.Y;

            Console.WriteLine($"\nРезультат: {intersects}");
        }

        // Методы InputRectangle, ReadDouble, ReadPositive аналогичны 17а


    }
}
