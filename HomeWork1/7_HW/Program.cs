using System;

/*
Используя Visual Studio, создайте проект по шаблону Windows Forms (.Net framework).
Создайте программу для расчета возраста пользователя, по введенному им году рождения
необходимо вывести его текущий возраст. (использовать DateTime).
*/

namespace _7_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter your birthday: ");
                    DateTime birthday = DateTime.Parse(Console.ReadLine());
                    DateTime today = DateTime.Today;

                    var totalDays = today.Subtract(birthday).TotalDays;
                    Console.WriteLine("Your age: " + Math.Truncate(totalDays / 365));
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid value");
                }
            }
            Console.ReadLine();
        }
    }
}
