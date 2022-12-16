using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Используя Visual Studio, создайте проект по шаблону Console Application.
Напишите программу, которая поможет первокласнику Пети, у которого m рублей .Мороженое
стоит k рублей. Петя решил наесться досыта мороженого, для этого он покупал по одному
мороженому и съедал его до тех пор, пока ему хватало денег. Как Пете узнать, сколько денег
останется у него в конце концов? учтите, что петя делить еще не умеет, а умеет только вычитать и
складывать. сколько мороженых он может съесть?.
 */

namespace _6_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int money = 150;
            int cost = 13;

            int counter = 0;
            while (true)
            {
                if (money - cost >= 0)
                {
                    money -= cost;
                    counter++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(counter);
            Console.ReadLine(); 
        }
    }
}
