using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Используя Visual Studio, создайте проект по шаблону Console Application.
Создать программу для определения синуса угла, ввод угла должен осуществлять
пользователь.
*/

namespace _4_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter angle value: ");
            float degree = float.Parse(Console.ReadLine());
            double rad = degree * Math.PI / 180;
            double result = Math.Sin(rad);

            Console.WriteLine($"sin({degree}) = {result}");

            Console.ReadLine();
        }
    }
}
