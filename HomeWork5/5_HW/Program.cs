using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
Создайте программу, в которой пользователь вводит прибыль фирмы за 12 месяцев. После чего
пользователь вводит диапазон (например, 3 и 6 – поиск между 3-м и 6-м месяцем). Необходимо
определить месяц, в котором прибыль была максимальна и месяц, в котором прибыль была
минимальна с учетом выбранного диапазона.
 */

namespace _5_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] profit  = {10, 20, 30, 50, 40, 100, 18, 33, 96, 5, 66, 35};

            Console.WriteLine("Enter start and end month:");
            int[] range = {int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())};

            int minProfit = int.MaxValue;
            int maxProfit = int.MinValue;
            int monthMinProfit = 0;
            int monthMaxProfit = 0;

            Console.WriteLine();

            if (range[0] >= 0 && range[0] <= 12 && range[1] >= 0 && range[1] <= 12 && range[1] > range[0])
            {
                for (int i = range[0] - 1; i < range[1]; i++)
                {
                    if (profit[i] > maxProfit)
                    {
                        maxProfit = profit[i];
                        monthMaxProfit = i + 1;
                    }
                    if (profit[i] < minProfit)
                    {
                        minProfit = profit[i];
                        monthMinProfit = i + 1;
                    }
                }
                Console.WriteLine($"В дипазоне месяцев от {range[0]}го до {range[1]}го");
                Console.WriteLine($"Максимальная прибыль была в {monthMaxProfit} и составила {maxProfit}");
                Console.WriteLine($"Минимальная прибыль была в {monthMinProfit} и составила {minProfit}");

            }
            Console.ReadLine();
        }
    }
}
