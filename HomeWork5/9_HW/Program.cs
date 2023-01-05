using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
Создайте программу, в которой создайте массив целых чисел размерности 10х10 и заполните его
случайными элементами. Выведете на консоль полученный массив. Найдите суммы элементов
каждой строки, произведения элементов каждого столбца, и максимальный элемент главной
диагонали (подсказка: все элементы, для которых номер строки совпадает с номером столбца).
 */

namespace _9_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int[,] arr = new int[10, 10];
            int[] sumSring = new int[arr.GetLength(0)];
            int[] productColumn = new int[arr.GetLength(1)];
            int maxDiagonal = int.MinValue;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = random.Next(1, 100);
                    sumSring[i] = sumSring[i] + arr[i, j];
                    productColumn[j] = productColumn[j] + arr[i, j];

                    maxDiagonal = i == j ? maxDiagonal < arr[i, j] ? arr[i, j] : maxDiagonal : maxDiagonal;

                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Sum string:");
            foreach (int item in sumSring)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Sum column:");
            foreach (int item in productColumn)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Max diagonal: {maxDiagonal}");


            Console.ReadLine();
        }
    }
}
