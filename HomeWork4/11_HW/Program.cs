using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

/*
 Используя Visual Studio, создайте проект по шаблону Console Application.
Представьте, что вы реализуете программу для банка, которая помогает определить, погасил ли
клиент кредит или нет. Допустим, ежемесячная сумма платежа должна составлять 100 грн.
Клиент должен выполнить 7 платежей, но может платить реже большими суммами. Т.е., может
двумя платежами по 300 и 400 грн. Закрыть весь долг.

Создайте метод, который будет в качестве аргумента принимать сумму платежа, введенную
экономистом банка. Метод выводит на экран информацию о состоянии кредита (сумма
задолженности, сумма переплаты, сообщение об отсутствии долга).
 */

namespace _11_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal debt = 700M;
            while (true)
            {
                Console.Write("Enter money: ");
                int money = int.TryParse(Console.ReadLine(), out money) ? money : 0;
                Method(ref debt, money);
                if (debt <= 0)
                {
                    break;
                }
            }
            
            Console.ReadLine();
        }

        public static void Method(ref decimal debt, decimal money)
        {
            debt -= money;
            if (debt > 0)
            {
                Console.WriteLine($"You have debt = {debt}");
            }
            else if (debt == 0)
            {
                Console.WriteLine("Your debt is repaid!!!");
            }
            else
            {
                Console.WriteLine($"Your overpayment = {debt}");
            }
        }
    }
}
