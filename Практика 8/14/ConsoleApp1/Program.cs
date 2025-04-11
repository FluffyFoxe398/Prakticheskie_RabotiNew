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
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random rnd = new Random();
            char[] password = new char[8];

            for (int i = 0; i < password.Length; i++)
            {
                password[i] = chars[rnd.Next(chars.Length)];
            }

            string result = new string(password);
            Console.WriteLine($"Сгенерированный пароль: {result}");

            Console.ReadKey();
        }
    }
}
