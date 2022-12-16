using System;

/*
Используя Visual Studio, создайте проект по шаблону Console Application.
Написать программу для расчета скидки за покупку, скидку и цену товара должен
осуществлять пользователь.
*/

namespace _6_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter cost: ");
                    float cost = float.Parse(Console.ReadLine());
                    Console.Write("Enter discount percent: ");
                    float discount = float.Parse(Console.ReadLine());

                    Console.WriteLine(Math.Round(cost - cost * (discount / 100), 2));
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
