using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Используя Visual Studio, создайте проект по шаблону Console Application.
Напишите программу определения, попадает ли указанное пользователем число от 0 до 100 в
числовой промежуток [0 - 14] [15 - 35] [36 - 50][50 - 100]. Если да, то укажите, в какой именно
промежуток. Если пользователь указывает число не входящее ни в один из имеющихся числовых
промежутков, то выводится соответствующее сообщение.
 */

namespace _8_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int value;

                Console.Write("enter value 0 - 100: ");
                string valueStr = Console.ReadLine();
                if (int.TryParse(valueStr, out value))
                {
                    if (value >= 0 && value < 15)
                    {
                        Console.WriteLine("your value in [0 - 14]");
                    }
                    else if (value >= 15 && value < 36)
                    {
                        Console.WriteLine("your value in [15 - 36]");
                    }
                    else if (value >= 36 && value < 50)
                    {
                        Console.WriteLine("your value in [36 - 50]");
                    }
                    else if (value >= 50 && value <= 100)
                    {
                        Console.WriteLine("your value in [50 - 100]");
                    }
                    else
                    {
                        Console.WriteLine("your value in out of range");
                    }
                }
            }
        }
    }
}
