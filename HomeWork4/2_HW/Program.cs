using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
Напишите программу в которой создайте метод, который в качестве аргументов принимает 2
числа и возвращает меньшее из них.
 */

namespace _2_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetLess(10, 15));
            Console.ReadLine();
        }

        public static int GetLess(int a, int b)
        {
            if (a < b)
            {
                return a;
            }

            return b;
        }
    }
}
