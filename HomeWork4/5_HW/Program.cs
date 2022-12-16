using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
Напишите программу для конвертирования валюты. Пользователь должен иметь возможность
ввести курс валюты, в которую он хочет конвертировать, сумму которую он хочет
конвертировать. Программа должна вывести сумму денег в соответствующей валюте.
 */

namespace _5_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetMoney(100, 36.5M));
            Console.ReadLine();
        }

        public static decimal GetMoney(decimal money, decimal course)
        {
            return money * course;
        }
    }
}
