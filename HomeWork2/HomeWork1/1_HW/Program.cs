using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Используя Visual Studio, создайте проект по шаблону Console Application.
Напишите программу, в которой создайте переменную a. Значение переменной, а должен задавать
пользователь. Если а < 10 то выведите'Верно', иначе (a>10) выведите 'Неверно'.
 */

namespace _1_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;

            while (true)
            {
                Console.Write("Enter value or 'out' for exit: ");
                string userValue = Console.ReadLine();
                if (int.TryParse(userValue, out a))
                {
                    if (a < 10)
                    {
                        Console.WriteLine("Верно");
                    }
                    else if (a >= 10)
                    {
                        Console.WriteLine("Не верно");
                    }
                    else
                    {
                    Console.WriteLine("Invalid Value");
                    }
                }
                if (userValue == "out")
                {
                    break;
                }

            }
            


            Console.ReadLine();
        }
    }
}
