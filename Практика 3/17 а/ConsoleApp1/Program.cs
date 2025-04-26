using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public struct Rectangle
        {
            public double X, Y;     // Левый нижний угол
            public double Width, Height;

            public double Right => X + Width;
            public double Top => Y + Height;
        }

        public static void Main()
        {
            Console.WriteLine("17а: Принадлежность первого прямоугольника второму");

            // Ввод параметров прямоугольников
            Rectangle rect1 = InputRectangle("первого");
            Rectangle rect2 = InputRectangle("второго");

            // Проверка условия
            bool isInside = rect1.X >= rect2.X &&
                            rect1.Y >= rect2.Y &&
                            rect1.Right <= rect2.Right &&
                            rect1.Top <= rect2.Top;

            Console.WriteLine($"\nРезультат: {isInside}");
        }

        static Rectangle InputRectangle(string name)
        {
            Console.WriteLine($"\nВвод {name} прямоугольника:");
            return new Rectangle
            {
                X = ReadDouble("X левого нижнего угла"),
                Y = ReadDouble("Y левого нижнего угла"),
                Width = ReadPositive("ширина"),
                Height = ReadPositive("высота")
            };
        }

        static double ReadDouble(string prompt)
        {
            while (true)
            {
                Console.Write($"{prompt}: ");
                if (double.TryParse(Console.ReadLine(), out double value))
                    return value;
                Console.WriteLine("Ошибка! Введите число.");
            }
        }

        static double ReadPositive(string prompt)
        {
            while (true)
            {
                double value = ReadDouble(prompt);
                if (value > 0) return value;
                Console.WriteLine("Значение должно быть положительным!");
            }
        }


    }
}
