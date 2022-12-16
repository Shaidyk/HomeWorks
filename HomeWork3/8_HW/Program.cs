using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Используя Visual Studio, создайте проект по шаблону Console Application.
Напишите программу, которая выводит на экран столько элементов ряда Фибоначчи, сколько
указал пользователь. Например, если на ввод поступило число 6, то вывод должен содержать
шесть первых чисел ряда Фибоначчи: 1 2 3 5 8 13. (Числа Фибоначчи -  элементы числовой
последовательности, в которой первые два числа равны либо 1 и 1, либо 0 и 1, а каждое
последующее число равно сумме двух предыдущих чисел, например 0, 1, 1, 2, 3, 5, 8, 13, 21, 34,
55, 89).
 */

namespace _8_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 10;

            int fibanachi = 1;
            int first = 0;
            int second = 0;

            for (int i = 1; i <= counter; i++)
            {
                if (fibanachi == 1)
                {
                    Console.Write($"{fibanachi} ");
                    first = 1;
                    second = 2;
                    fibanachi++;
                }
                else 
                {
                    Console.Write($"{fibanachi}, ");
                    fibanachi = first + second;
                    first = second;
                    second = fibanachi;
                }
            }

            Console.ReadLine();
        }
    }
}
