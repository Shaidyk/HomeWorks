using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
Напишите программу, в которой создайте метод, который принимает в качестве параметров три
целочисленных значения и возвращает значение каждого аргумента, умноженного на 10.
(Использовать out и ref)
 */

namespace _6_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;

            MultiWithOut(out a, out b, out c);  // This method always run first, because a, b, c defined inside method.
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            MultiWithRef(ref a, ref b, ref c);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            Console.ReadLine();
        }

        public static void MultiWithRef(ref int a, ref int b, ref int c)
        {
            a *= 10;
            b *= 10;
            c *= 10;
        }

        public static void MultiWithOut(out int a, out int b, out int c)
        {
            a = 1;
            b = 2;
            c = 3;

            a *= 10;
            b *= 10;
            c *= 10;
        }
    }
}
