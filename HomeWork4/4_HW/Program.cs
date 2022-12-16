using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
Напишите программу консольный калькулятор. В данной программе должны быть четыре
метода, метод для сложения, вычитания, умножения и деления. Каждый из методов должен
принимать 2 целочисленных аргумента и выполнять соответствующею действие. Метод для
деления должен выполнять проверку деления на ноль. Также необходимо предоставить
пользователю возможность вводить знак арифметической операции, в зависимости от знака
вызывать соответствующий метод. Также пользователю необходимо предоставить возможность
вводит значения аргументов.
 */

namespace _4_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first value: ");
            int firstValue = int.TryParse(Console.ReadLine(), out firstValue) ? firstValue : 0;
            Console.Write("Enter second value: ");
            int secondValue = int.TryParse(Console.ReadLine(), out secondValue) ? secondValue : 0;
            Console.Write("Enter sign: ");
            string sign = Console.ReadLine();

            switch (sign)
            {
                case "+":
                    Console.WriteLine(Sum(firstValue, secondValue));
                    break;
                case "-":
                    Console.WriteLine(Diff(firstValue, secondValue));
                    break;
                case "*":
                    Console.WriteLine(Multiplication(firstValue, secondValue));
                    break;
                case "/":
                    Console.WriteLine(Division(firstValue, secondValue));
                    break;
                default:
                    Console.WriteLine($"I dont know '{sign}' sign");
                    break;
            }

            Console.ReadLine();
        }
        public static int Sum(int a, int b)
        {
            return a + b;
        }
        public static int Diff(int a, int b)
        { 
            return a - b; 
        }
        public static int Multiplication(int a, int b)
        {
            return a * b;
        }
        public static double Division(int a, int b) 
        {
            if (b == 0)
            {
                Console.WriteLine("Error Zedo Division");
                return 0;
            }

            return (double)a / b;
        }
    }
}
