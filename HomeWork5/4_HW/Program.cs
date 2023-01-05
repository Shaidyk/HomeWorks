using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
Создайте программу, в которой создайте метод, который в качестве параметра принимает слово,
а возвращает тоже слово, но с измененным порядком букв в слове на обратный.
 */

namespace _4_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string baseStr = "Hello, world";

            Console.WriteLine(StrReverse(baseStr));

            Console.ReadLine();
        }

        static string StrReverse(string oldStr)
        {
            string newStr = "";

            for (int i = oldStr.Length - 1; i >= 0; i--)
            {
                newStr += oldStr[i];
            }

            return newStr;
        }
    }
}
