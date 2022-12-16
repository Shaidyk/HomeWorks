using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Используя Visual Studio, создайте проект по шаблону Console Application.
Имеется 3 переменные типа int x = 10, y = 12, и z = 3; Выполните и рассчитайте результат
следующих операций для этих переменных:
x += y - x++ * z;
z = --x - y * 5;
y /= x + 5 % z;
z = x++ + y * 5;
x = y - x++ * z;
*/

namespace _8_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10, y = 12, z = 3;

            x += y - x++ * z;  // -8

            x = 10;
            y = 12; 
            z = 3;
            z = --x - y * 5;  // -51

            x = 10;
            y = 12;
            z = 3;
            y /= x + 5 % z;  // 1

            x = 10;
            y = 12;
            z = 3;
            z = x++ + y * 5;  // 70

            x = 10;
            y = 12;
            z = 3;
            x = y - x++ * z;  // -18

            Console.ReadLine();
        }
    }
}
