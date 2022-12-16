using System;

/*
Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте программу для перевода метров в сантиметры (1м = 100см), ввод метров должен
осуществлять пользователь.
*/

namespace _1_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float meters, smeters;
            string userValue;

            while (true)
            {
                Console.Write("Enter meters to convert or \"quit\" for exit: ");
                userValue = Console.ReadLine().Replace(".", ",");

                if (float.TryParse(userValue, out meters) )
                {
                    smeters = meters * 100;
                    Console.WriteLine(smeters);
                }
                else if (userValue == "quit")
                    break;
                else
                    Console.WriteLine("Invalid value");
            }
        }
    }
}
