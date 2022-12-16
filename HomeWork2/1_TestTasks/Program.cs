using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Дано 2 числа, а = 10, b = 20. Написать программу, которая выполняет сложение данных чисел,
вычитание, умножение, деление, получения остатка от деления, переменные которые хранят
результат данных операция должны быть типа byte. Результат выполнения программы вывести на
Console.
 */

namespace _1_TestTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte a = 10;
            byte b = 20;

            byte result;

            result = (byte)(a + b);
            Console.WriteLine($"Result: {result}\t  Type: {result.GetType()}");
            result = (byte)(a - b);
            Console.WriteLine($"Result: {result}\t  Type: {result.GetType()}");
            result = (byte)(a * b);
            Console.WriteLine($"Result: {result}\t  Type: {result.GetType()}");
            result = (byte)(a / b);
            Console.WriteLine($"Result: {result}\t  Type: {result.GetType()}");
            result = (byte)(a % b);
            Console.WriteLine($"Result: {result}\t  Type: {result.GetType()}");


            Console.ReadLine();
        }
    }
}
