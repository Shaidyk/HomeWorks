using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Используя Visual Studio, создайте проект по шаблону Console Application.
Напишите программу, которая будет рассчитывать сумму вклада в банк. Процентную ставку,
сумму и срок на которой положили вклад, должен вводить пользователь с клавиатуры.
 */

namespace _4_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("%: ");
                float percent = float.TryParse(Console.ReadLine(), out percent) ? percent : 0;
                Console.Write("Sum: ");
                float sum = float.TryParse(Console.ReadLine(), out sum) ? sum : 0;
                Console.Write("Term: ");
                float term = float.TryParse(Console.ReadLine(), out term) ? term : 0;

                if (percent <= 0 || sum <= 0 || term <= 0)
                {
                    Console.WriteLine("Invalid value< try again.");
                    continue;
                }

                Console.WriteLine(sum += sum * (percent / 100) * term);
                break;
            }

            Console.ReadLine();
           
        }
    }
}
