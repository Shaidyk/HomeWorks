using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

/*
 Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
Создайте программу, в которой создайте два строковых массива с именами A и B (размерностью
4 элемента). Массив A заполняется в цикле пользователем. Получить результирующий массив B,
обратный к исходному массиву A (элементы массива B идут в обратном порядке по отношению к
массиву A).
 */

namespace _3_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] A = new string[4];

            for (int i = 0; i < A.Length; i++)
            {
                Console.Write("Enter array element: ");
                A[i] = Console.ReadLine();
            }

            string[] B = GetArr(A);

            for (int i = 0; i < B.Length; i++)
            {
                Console.WriteLine(B[i]);
            }

            Console.Read();
        }

        static string[] GetArr(string[] oldArr)
        {
            string[] newArr = new string[oldArr.Length];
            for (int i = 0; i < oldArr.Length; i++)
            {
                newArr[(newArr.Length - 1) - i] = oldArr[i];
            }
            return newArr;
        }
    }
}
