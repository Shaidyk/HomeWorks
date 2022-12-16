using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
Напишите программу в которой создайте метод, который принимает в качестве параметров три
целочисленных аргумента и выводит на экран среднее арифметическое значений аргументов.
 */

namespace _1_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Average(3, 7, 10));

            Console.ReadLine();
        }

        public static double Average(int x, int y, int z)
        {
            return (double)(x + y + z) / 3;
        }
    }
}
