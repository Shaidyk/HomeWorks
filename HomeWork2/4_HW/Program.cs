using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
 Используя Visual Studio, создайте проект по шаблону Console Application.
Напишите программу, в которой пользователь вводит целое число. Программа в свою очередь
должна ответить, четным или нечетным является это число, делится ли оно на 3 и делится ли оно на 6.
 */

namespace _4_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value;

            while (true)
            {
                Console.Write("Enter Value: ");
                if (int.TryParse(Console.ReadLine(), out value))
                {
                    if (value % 2 == 0)
                    {
                        Console.WriteLine($"{value} - четное число");
                    }
                    else
                    {
                        Console.WriteLine($"{value} - не четное число");
                    }
                    if (value % 3 == 0 && value % 6 == 0)
                    {
                        Console.WriteLine($"{value} - делится на 3 и на 6");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid value");
                }
            }
        }
    }
}
