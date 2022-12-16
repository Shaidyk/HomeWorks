using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Дана длина окружности. Найти ее радиус и площадь круга, ограниченного этой окружностью,
учитывая, что, . В качестве значения использовать 3.14
 */

namespace _2_TestTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int circumference = 10;
            const float PI = 3.14f;

            double R;
            double S;

            R = circumference / (2 * PI);
            S = PI * Math.Pow(R, 2);

            Console.WriteLine($"Радиус {R}, Площадь {S}");
            Console.ReadLine();
        }
    }
}
