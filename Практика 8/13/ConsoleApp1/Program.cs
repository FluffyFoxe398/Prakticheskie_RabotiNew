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
            string file1 = "file1.txt";
            string file2 = "file2.txt";
            string resultFile = "result.txt";

            if (!File.Exists(file1) || !File.Exists(file2))
            {
                Console.WriteLine("Один из файлов не найден.");
            }
            else
            {
                string content1 = File.ReadAllText(file1);
                string content2 = File.ReadAllText(file2);

                File.WriteAllText(resultFile, content1 + Environment.NewLine + content2);
                Console.WriteLine("Файлы успешно объединены в result.txt");
            }

            Console.ReadKey();
        }
    }
}
