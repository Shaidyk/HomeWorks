using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Используя Visual Studio, создайте проект по шаблону Console Application.
Напишите программу, которая будет складывать, вычитать, умножать или делить два числа.
Числа и знак операции вводятся пользователем. После выполнения вычисления программа не
должна завершаться, а должна запрашивать новые данные для вычислений. Завершение
программы должно выполняться при вводе символа 'O'; в качестве знака операции. Если
пользователь вводит неверный знак (не 'O'; '+'; '-'; '*'; '/'), то программа должна сообщать ему об
ошибке и снова запрашивать знак операции. Также сообщать пользователю о невозможности
деления на ноль, если он ввел 0 в качестве делителя.
 */

namespace _10_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter first value: ");
                float firstValue = float.TryParse(Console.ReadLine(), out firstValue) ? firstValue : 0;
                Console.Write("Enter second value: ");
                float secondValue = float.TryParse(Console.ReadLine(), out secondValue) ? secondValue : 0;
                Console.Write("Enter operation sign: ");
                string sign = Console.ReadLine();

                if (sign == "O")
                {
                    break;
                }

                switch (sign)
                {
                    case "+":
                        Console.WriteLine(firstValue + secondValue);
                        continue;
                    case "-":
                        Console.WriteLine(firstValue - secondValue);
                        continue;
                    case "*":
                        Console.WriteLine(firstValue * secondValue);
                        continue;
                    case "/":
                        Console.WriteLine(firstValue / secondValue);
                        continue;
                    default:
                        Console.WriteLine("Invalid sign");
                        continue;
                }
            }
        }
    }
}
