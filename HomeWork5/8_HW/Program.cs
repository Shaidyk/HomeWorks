using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
Создайте программу, в которой создайте метод, который будет выполнять увеличение длины
массива переданного в качестве аргумента, на 1 элемент. Метод, должен принимает два
аргумента, первый аргумент - типа int[] array, второй аргумент - типа int value. В теле
метода реализуйте возможность добавления второго аргумента метода в массив по индексу – 0,
при этом длина нового массива, должна увеличиться на 1 элемент, а элементы получаемого
массива в качестве первого аргумента должны скопироваться в новый массив начиная с индекса - 1.
 */

namespace _8_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {10, 20, 30};

            int[] newArr = AddToStartPos(arr, 999);

            foreach (var item in newArr)
            {
                Console.WriteLine(item);
            }

            Console.Read();
        }

        static int[] AddToStartPos(int[] arr, int value)
        {
            int[] tempArr = new int[arr.Length + 1];
            tempArr[0] = value;

            for (int i = 0; i < arr.Length; i++)
            {
                tempArr[i + 1] = arr[i];
            }

            return tempArr;
        }
    }
}
