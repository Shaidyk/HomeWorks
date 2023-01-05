using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
Создайте программу, в которой создает метод, который в качестве аргументов принимает:
1)целочисленный массив(int [] array), 2)целочисленный индекс(int index), 3)количество
элементов (int count), возвращает целочисленный массив элементов(int [] subArray).
Метод возвращает часть полученного в качестве аргумента массива, начиная с позиции
указанной в аргументе index, размерностью, которая соответствует значению аргумента count.
 */

namespace _7_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 10, 20, 32, 343, 13212, 23, 54 };
            int index = 3;
            int count = 20;
            int[] subArr = UpdateArr(arr, index, count);

            for (int i = 0; i < subArr.Length; i++)
            {
                Console.WriteLine(subArr[i]);
            }

            Console.ReadLine();
        }

        static int[] UpdateArr(int[] arr, int index, int count)
        {
            int[] subArray = new int[count];
            int position = 0;

            for (int i = index; i < arr.Length; i++)
            {
                if (position < count)
                {
                    subArray[position] = arr[i];
                    position++;
                }
                else
                {
                    break;
                }
            }
            return subArray;
        }
    }
}
