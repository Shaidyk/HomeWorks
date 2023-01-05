using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
Создайте программу, в которой создайте массив размерностью в 5 элементов, выведите на экран
все элементы массива в обратном порядке.
 */

namespace _2_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadLine();
        }
    }
}
