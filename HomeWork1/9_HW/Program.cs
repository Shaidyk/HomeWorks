using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Используя Visual Studio, создайте проект по шаблону Console Application.
Напишите программу расчета объема - V и площади поверхности -S цилиндра. Объем V
цилиндра радиусом – R и высотой – h, вычисляется по формуле: . Площадь S поверхности
цилиндра вычисляется по формуле: S = 2πR(R+h). Результаты расчетов выведите на экран.
Пользователь должен иметь возможность вводит r – радиус цилиндра и h – высоту цилинда.
 */

namespace _9_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double S;
            double V;
            Console.Write("Enter r: ");
            float r = float.Parse(Console.ReadLine());
            Console.Write("Enter h: ");
            float h = float.Parse(Console.ReadLine());

            S = 2 * Math.PI * r * (r + h);
            Console.WriteLine(S);

            V = Math.PI * Math.Pow(r, 2) * h;
            Console.WriteLine(V);

           Console.ReadLine();
        }
    }
}
