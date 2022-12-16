using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Используя Visual Studio, создайте проект по шаблону Console Application.
Напишите программу, которая будет
 */

namespace _1_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;

            while (true)
            {
                counter++;  
                Console.WriteLine(counter);
                if (counter == 5) 
                {
                    break;
                }
            }
            Console.WriteLine();

            counter = 0;
            do
            {
                counter++;
                Console.WriteLine(counter);
                if (counter == 5)
                {
                    break;
                }
            } while (true);
            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i + 1);
            }

            Console.ReadLine();
        }
    }
}
