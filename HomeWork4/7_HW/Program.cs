using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
Написать программу, в которой создайте один метод, который будет вычислять площадь и
периметр прямоугольника. Сторони прямоугольника пользователь должен иметь возможность
вводит с клавиатуры.
 */

namespace _7_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RectangleParametrs(5, 7);
            Console.ReadLine();
        }

        public static void RectangleParametrs(int a, int b)
        {
            Console.WriteLine($"P = {a * 2 + b * 2}");
            Console.WriteLine($"S = {a * b}");
        }
    }
}
