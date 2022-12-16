using System;

/*
Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте константу с именем -pi (число π «пи»), создайте переменную радиус с именем – r.
Используя формулу πR 2 , вычислите площадь круга и выведите результат на экран.
*/

namespace _2_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const float PI = 3.14f;
            float r = 8f;
            double result;

            result = PI * Math.Pow(r, 2);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
