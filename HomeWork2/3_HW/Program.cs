using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Используя Visual Studio, создайте проект по шаблону Console Application.
Напишите программу, в которой создайте переменную min. Значение переменной должен задавать
пользователь, интервал допустимых значений 0 до 59, необходимо организовать проверку на ввод
допустимого интервала. Определите в какую четверть часа попадает значение переменной (в
первую, вторую, третью или четвертую).
 */

namespace _3_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int min;

            while (true)
            {
                Console.Write("Enter value: ");
                if (int.TryParse(Console.ReadLine(), out min))
                {
                    if (min >= 0 && min <= 59)
                    {
                        if (min >= 0 && min <= 15)
                        {
                            Console.WriteLine("included in the 'I' quarter");
                        }
                        else if (min > 15 && min <= 30)
                        {
                            Console.WriteLine("included in the 'II' quarter");
                        }
                        else if (min > 30 && min <= 45)
                        {
                            Console.WriteLine("included in the 'III' quarter");
                        }
                        else
                        {
                            Console.WriteLine("included in the 'IV' quarter");
                        }
                    }
                }
            }
        }
    }
}
