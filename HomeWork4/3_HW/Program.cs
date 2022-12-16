using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
Создайте программу, в которой создайте метод, который принимает в качестве аргумента год
рождения пользователя и возвращает его полный возраст.
 */

namespace _3_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetAge(1990));
            Console.ReadLine();
        }

        public static int GetAge(int year)
        {
            return DateTime.Now.Year - year;
        }
    }
}
