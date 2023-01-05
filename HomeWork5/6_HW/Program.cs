using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
Создайте программу, в которой создайте массив размера N элементов (размер массива задет
пользователь), заполнить его произвольными целыми значениями. Вывести на экран:
наибольшее значение массива, наименьшее значение массива, общую сумму всех элементов,
среднее арифметическое всех элементов, вывести все нечетные значения.
 */

namespace _6_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Element's count: ");
            int[] arr = new int[int.Parse(Console.ReadLine())];
            Random random = new Random();
            int maxValue = int.MinValue;
            int minValue = int.MaxValue;
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(1, 100);
                Console.WriteLine(arr[i]);
            }

            Console.WriteLine();

            for (int i = 0; i < arr.Length; i++)
            {
                maxValue = arr[i] > maxValue ? arr[i] : maxValue;
                minValue = arr[i] < minValue ? arr[i] : minValue;
                sum += arr[i];
                if (arr[i] % 2 != 0)
                {
                    Console.WriteLine($"Odd {arr[i]}");
                }
            }

            Console.WriteLine($"Min value: {minValue}");
            Console.WriteLine($"Max value: {maxValue}");
            Console.WriteLine($"Sum all elements: {sum}");
            Console.WriteLine($"Avarage: {sum / arr.Length}");

            Console.ReadLine();
        }
    }
}
