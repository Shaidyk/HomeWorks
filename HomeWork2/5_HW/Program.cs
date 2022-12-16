using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Используя Visual Studio, создайте проект по шаблону Console Application.
Напишите программу, которая решает квадратное уравнение. Пользователь должен ввести
коэффициенты а, b и с квадратного уравнения ах2 + bх + с = 0. После чего программа должна
вывести на экран все корни этого уравнения или сообщение о том, что их нет. Рассмотреть случаи
когда дискриминант (D) квадратного уравнения > 0, когда D<0 и когда D = 0.
 */

namespace _5_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int a, b, c;

                Console.Write("Enter a: ");
                string aStr = Console.ReadLine();
                Console.Write("Enter b: ");
                string bStr = Console.ReadLine();
                Console.Write("Enter c: ");
                string cStr = Console.ReadLine();

                if (int.TryParse(aStr, out a) && int.TryParse(bStr, out b) && int.TryParse(cStr, out c))
                {
                    double D = Math.Pow(b, 2) - 4 * a * c;
                    Console.WriteLine($"Math.Pow(b, 2)={Math.Pow(b, 2)}  ,  - 4 * a * c = {-4 * a * c}");
                    Console.WriteLine(D);
                    if (D < 0)
                    {
                        Console.WriteLine($"D: {D} < 0, Корней нет");
                    }
                    else if (D == 0)
                    {
                        Console.WriteLine($"D: {D} = 0, result = {-b / 2 * a}");
                    }
                    else
                    {
                        Console.WriteLine($"D: {D} > 0, first root of the equation = {-b + Math.Sqrt(D) / (2 * a)}");
                        Console.WriteLine($"D: {D} > 0, second root of the equation = {-b - Math.Sqrt(D) / (2 * a)}");
                    }
                }
            }
        }
    }
}
