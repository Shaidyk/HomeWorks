using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Используя Visual Studio, создайте проект по шаблону Console Application.
Напишите программу - консольный калькулятор. Создайте две переменные с именами operand1 и
operand2. Задайте переменным некоторые произвольные значения. Предложите пользователю
ввести знак арифметической операции. Примите значение введенное пользователем и поместите
его в строковую переменную sign. Для организации выбора алгоритма вычислительного процесса,
используйте переключатель switch. Выведите на экран результат выполнения арифметической
операции. В случае использования операции деления, организуйте проверку попытки деления на
ноль. И если таковая имеется, то отмените выполнение арифметической операции и уведомите об
ошибке пользователя.
 */

namespace _7_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int operand1 = 12;
                int operand2 = 0;

                Console.Write($"operand1 = {operand1}, operand2 = {operand2} - enter operation: ");
                string statement = Console.ReadLine();

                switch (statement)
                {
                    case "+":
                        Console.WriteLine(operand1 + operand2);
                        break;
                    case "-":
                        Console.WriteLine(operand1 - operand2);
                        break;
                    case "*":
                        Console.WriteLine(operand1 * operand2);
                        break;
                    case "/":
                        if (operand2 != 0)
                        {
                            Console.WriteLine((double)operand1 / operand2);
                        }
                        else
                        {
                            Console.WriteLine("Error ZeroDivision");
                        }
                        break;
                }
            }
        }
    }
}
