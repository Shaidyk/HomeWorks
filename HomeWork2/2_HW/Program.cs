using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Используя Visual Studio, создайте проект по шаблону Console Application.
Напишите программу, которая будет рассчитывать процент скидки в зависимости от количества
купленного товара. Если куплено больше 3 единиц товара, тогда скидка должна быть 10 процентов
от общей суммы, если же количество больше 3 и меньше 7, то 20процентов от общей суммы, иначе,
если больше 7 то 25 процентов от общей суммы. Цену товара и купленное количество товара
пользователь должен задавать вводом с консоли.
 */

namespace _2_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count;
            decimal cost;
            decimal sale;

            Console.Write("Enler count of product: ");
            string userCountValue = Console.ReadLine();

            Console.Write("Enler cost of product: ");
            string userCostValue = Console.ReadLine();

            if (int.TryParse(userCountValue, out count) && decimal.TryParse(userCostValue, out cost))
            {
                if (count > 0 && count <= 3)
                {
                    sale = 0.1M;
                    Console.WriteLine(cost -= cost * sale);
                }
                else if (count > 3 && count <= 7)
                {
                    sale = 0.2M;
                    Console.WriteLine(cost -= cost * sale);
                }
                else if (count > 7)
                {
                    sale = 0.25M;
                    Console.WriteLine(cost -= cost * sale);
                }
            }
            else
            {
                Console.WriteLine("Invalid value");
            }
            
            Console.ReadLine();
        }
    }
}
