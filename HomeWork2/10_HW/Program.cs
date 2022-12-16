using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Используя Visual Studio, создайте проект по шаблону ConsoleApplication. Напишите программу
расчета начисления премий сотрудникам. Премии рассчитываются согласно выслуге лет. Если

выслуга до 5 лет, премия составляет 10% от заработной платы. 
Если выслуга от 5 лет (включительно) до 10 лет, премия составляет 15% от заработной платы. 
Если выслуга от 10 лет (включительно) до 15лет, премия составляет 25% от заработной платы. 
Если выслуга от 15 лет (включительно) до 20 лет, премия составляет 35% от заработной платы. 
Если выслуга от 20 лет (включительно) до 25 лет, премия составляет 45% от заработной платы. 
Если выслуга от 25 лет (включительно) и более, премия составляет 50% от заработной платы. 
Результаты расчета, выведите на экран.
 */

namespace _10_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter your experience: ");
                int experience = int.Parse(Console.ReadLine());

                if (experience > 0 && experience < 5)
                {
                    Console.WriteLine("your bonus 10%");
                }
                else if (experience >= 5 && experience < 10)
                {
                    Console.WriteLine("your bonus 15%");
                }
                else if (experience >= 10 && experience < 15)
                {
                    Console.WriteLine("your bonus 25%");
                }
                else if (experience >= 15 && experience < 20)
                {
                    Console.WriteLine("your bonus 35%");
                }
                else if (experience >= 20 && experience < 25)
                {
                    Console.WriteLine("your bonus 45%");
                }
                else if (experience >= 25)
                {
                    Console.WriteLine("your bonus 50%");
                }
                
            }
        }
    }
}
