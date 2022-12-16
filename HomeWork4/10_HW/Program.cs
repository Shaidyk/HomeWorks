using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
Напишите программу, в которой создайте метод, который в качестве аргумента принимает целое
число и определяет количество разрядов данного числа. Пользователь должен иметь
возможность вводит число с клавиатуры.
 */

namespace _10_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter value: ");
            int n = int.TryParse(Console.ReadLine(), out n) ? n : 0;
            Console.WriteLine($"Bit depth {n} = {GetValueBitDepth(n)}");
            Console.ReadLine();
        }
        public static int GetValueBitDepth(int n)
        {
            return n.ToString().Length;
        }
    }
}
