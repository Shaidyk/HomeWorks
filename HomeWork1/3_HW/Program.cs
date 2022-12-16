using System;

/*
Используя Visual Studio, создайте проект по шаблону Console Application.
Создать программу для определения гипотенузы прямоугольного треугольника,
используя формулу , где с – гипотенуза, а b и a катеты прямоугольного треугольника.
Ввод катетов должен осуществлять пользователь.
*/

namespace _3_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstLeg;
            string secondLeg;
            double hypotenuse;

            while (true)
            {
                try
                {
                    Console.Write("Enter first leg: ");
                    firstLeg = Console.ReadLine();
                    Console.Write("Enter second leg: ");
                    secondLeg = Console.ReadLine();

                    hypotenuse = Math.Sqrt(Math.Pow(float.Parse(firstLeg), 2) + Math.Pow(float.Parse(secondLeg), 2));
                    Console.WriteLine($"Hypotenuse = {hypotenuse}");
                    break;
                }
                catch (Exception)
                {

                    Console.WriteLine("Invalid value, try again.");
                }
            }

            Console.ReadLine();
        }
    }
}
