using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Создать программу, которая запрашивает имя пользователя и здоровается с ним. Для вывода
информации использовать 3 варианта конкатенации строк.
 */

namespace _3_TestTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hi, enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine($"Hello {name}");
            Console.WriteLine("Hello " + name);
            Console.WriteLine(string.Format(@"Hello {0}", name));

            Console.ReadLine();
        }
    }
}
