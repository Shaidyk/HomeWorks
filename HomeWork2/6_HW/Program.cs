using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Используя Visual Studio, создайте проект по шаблону Console Application.
Напишите программу, которая определяет, является ли год високосным. Пользователь вводит год.
Программа должна вывести на экран ответ, является ли год високосным. Подсказка. Обычно
каждый год, который делится на 4, — это високосный год, кроме лет столетий (делящихся на 100).
Но среди последних год, делящийся на 400, также считается високосным.
 */

namespace _6_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int year;
                Console.WriteLine("Enter year: ");
                string yearStr = Console.ReadLine();

                if (int.TryParse(yearStr, out year))
                {
                    if (year % 4 == 0)
                    {
                        if (year % 100 == 0)
                        {
                            if (year % 400 == 0)
                            {
                                Console.WriteLine("Высокосный");
                            }
                            else
                            {
                                Console.WriteLine("НЕ Высокосный");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Высокосный");
                        }
                    }
                    else
                    {
                        Console.WriteLine("НЕ Высокосный");
                    }
                }
            }
        }
    }
}
