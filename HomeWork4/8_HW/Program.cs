using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
Напишите программу, в которой создайте метод, который выведет все числа от 1 до N. N – число
которое пользователь вводит с клавиатуры. (Использовать рекурсию)
 */

namespace _8_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N: ");
            int n = int.TryParse(Console.ReadLine(), out n) ? n : 0;
            GetRange(n);
            Console.ReadLine();
        }

        public static void GetRange(int n)
        {
            if (n > 0)
            {
                GetRange(n - 1);
                Console.WriteLine(n);
            }

            return;
        }
    }
}
