using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void PrintDigits(int n)
        {
            if (n == 0)
            {
                Console.WriteLine(0);
                return;
            }

            // Для хранения цифр в правильном порядке
            int[] digits = new int[10];
            int count = 0;

            while (n > 0)
            {
                digits[count] = n % 10;
                n /= 10;
                count++;
            }

            // Выводим в обратном порядке
            for (int i = count - 1; i >= 0; i--)
            {
                Console.Write(digits[i] + " ");
            }

            Console.WriteLine();
        }

        static void Main()
        {
            Console.Write("Введите целое число N: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Цифры числа: ");
            PrintDigits(n);

            Console.ReadKey();
        }
    }
}
