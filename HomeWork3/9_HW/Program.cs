using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Используя Visual Studio, создайте проект по шаблону Console Application.
Напишите программу, в которой запросите пользователя ввести два числа A и B (A<B), если (A>B
выведите соответствующее предупреждение) и выведите суму всех чисел расположенных между
данными числами на экран. Дано два числа A и B (A<B) выведите все нечетные значения,
расположенные между данными числами.
 */

namespace _9_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter two values when first value less then second value.");
                Console.Write("Enter first value: ");
                int A = int.TryParse(Console.ReadLine(), out A) ? A : 0;
                Console.Write("Enter second value: ");
                int B = int.TryParse(Console.ReadLine(), out B) ? B : 0;

                if (A > B)
                {
                    int result = 0;
                    Console.WriteLine("WARNING: second value less then first value.");
                    for (int i = B; i < A; i++)
                    {
                        result += i;
                    }
                    Console.WriteLine($"Sum: {result}");
                }
                else
                {
                    for (int i = A; i < B; i++)
                    {
                        if (i % 2 != 0)
                        {
                            Console.WriteLine(i);
                        }
                    }
                }
            }
        }
    }
}
