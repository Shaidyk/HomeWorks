using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте программу, в которой создайте класс «Треугольник». В теле класса создайте три
закрытых поля для описания сторон треугольника и три свойства для чтения и записи. Также в
теле класса создайте 3 метода: 1-й для расчета площади треугольника, формула для расчета S =
√p ∗ (p − a) ∗ (p − b) ∗ (p − c), где p - полупериметр треугольника p = (a + b + c)/2, a, b, c –
длины сторон треугольника, 2-й для расчета периметра треугольника, формула для расчета p =
(a + b + c)/2 и 3-й для вывода информации о площади и периметре треугольника. Создайте
конструктор, который в качестве аргументов приминимает стороны треугольника и
инициализирует поля класса. В методе Main() создайте экземпляр класса «Треугольник», задайте
произвольное значение сторон треугольника и выведите на экран значение периметра и
площади треугольника.
 */

namespace _04_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(5, 7, 8);
            triangle.GetTriangleInfo();

            Console.ReadLine();
        }
    }

    class Triangle
    {
        private float a;
        private float b;
        private float c;

        public float A { get { return a; } set { a = value; } }
        public float B { get { return b; } set { b = value; } }
        public float C { get { return c; } set { c = value; } }
        public Triangle(float a, float b, float c)
        {
            A = a;
            B = b;
            C = c;
        }

        private double TriangleArea()
        {
            float p = TrianglePerimeter() / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        private float TrianglePerimeter()
        {
            return a + b + c;
        }

        public void GetTriangleInfo()
        {
            Console.WriteLine($"Triangle's perimeter = {TrianglePerimeter()}");
            Console.WriteLine($"Triangle's area = {TriangleArea()}");
        }
    }
}
