using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Используя Visual Studio, создайте проект по шаблону Console Application.
Напишите программу, в которой создайте две целочисленные переменные и задайте им
некоторые значения. Применяя технику вложенных циклов, нарисуйте прямоугольник из
звездочек. Используйте значения ранее созданных переменных для указания высоты и ширины
прямоугольника
 */

namespace _7_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int height = 10;
            int width = 10; 

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (i == 0 || i == height - 1)
                    {
                        Console.Write("*");
                    }
                    else 
                    {
                        if (j == 0 || j == width - 1)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
