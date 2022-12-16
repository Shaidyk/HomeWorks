using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Используя Visual Studio, создайте проект по шаблону Console Application.
Напишите программу, где пользователь вводит любое целое положительное число. А программа
суммирует все числа от 1 до введенного пользователем числа.
 */

namespace _5_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter value: ");
                uint value = uint.TryParse(Console.ReadLine(), out value) ? value : 0;

                if (value == 0)
                {
                    Console.WriteLine("try again");
                    continue;
                }

                int result = 0;
                for (int i = 0; i < value; i++)
                {
                    result += i;
                }

                Console.WriteLine(result);
            }
            

        }
    }
}
