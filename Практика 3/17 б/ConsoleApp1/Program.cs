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
            Console.WriteLine("17б: Проверка вложенности прямоугольников");

            Rectangle rect1 = InputRectangle("первого");
            Rectangle rect2 = InputRectangle("второго");

            bool isFirstInSecond = IsContained(rect1, rect2);
            bool isSecondInFirst = IsContained(rect2, rect1);

            Console.WriteLine($"\nРезультат: {isFirstInSecond || isSecondInFirst}");
        }

        static bool IsContained(Rectangle inner, Rectangle outer)
        {
            return inner.X >= outer.X &&
                   inner.Y >= outer.Y &&
                   inner.Right <= outer.Right &&
                   inner.Top <= outer.Top;
        }

        // Методы InputRectangle, ReadDouble, ReadPositive аналогичны 17а


    }
}
