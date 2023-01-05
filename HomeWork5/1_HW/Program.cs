using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
Создайте программу, в которой создайте массив размерностью в 5 элементов, выведите на экран
все элементы массива.
 */

namespace _1_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
