using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Используя Visual Studio, создайте проект по шаблону Console Application.
Напишите программу, которая будет выводить на экран таблицу умножения на 3.
 */

namespace _2_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{i} * 3 = {i * 3}");
            }

            Console.Read();
        }
    }
}
