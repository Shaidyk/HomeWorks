using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
Напишите программу, которая будет вычислять сумму цифр числа N. Число N пользователь
должен вводить с клавиатуры. При решении этой задачи нельзя использовать строки, списки,
массивы (ну и циклы, разумеется). (Использовать рекурсию)
 */

namespace _9_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter value: ");
            int n = int.TryParse(Console.ReadLine(), out n) ? n : 0;
            Console.WriteLine(GetSumAllValues(n));
            Console.ReadLine();
        }

        public static int GetSumAllValues(int n)
        {
            if (n > 0)
            {
                n += GetSumAllValues(n - 1);
            }
            return n;
        }
    }
}
