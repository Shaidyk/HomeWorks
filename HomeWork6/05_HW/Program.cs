using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

/*
 Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте программу, в которой создайте класс «Точка» – для описания координат точки на
координатной прямой рис No1. В теле класса создайте следующие закрытые поля: целочисленное
поле для описания координаты точки X и целочисленное поле для описания координаты точки
Y, а также строковое поле для имени точки. Создать три свойства с методами доступа get и
set, а также конструктор класса, который будет инициализировать данные поля значениями
аргументов. Далее создайте класс «Фигура». В теле класса фигура создайте одно поле типа масив
«Точек» и одно строкове поле для имени фигуры и 2 конструктора, которые принимают 3
(треугольника) и 4 аргумента (четырехугольника). В теле класса «Фигура» создайте два метода: 1-
й для расчета длины стороны фигуры, метод должен принимать 2 аргумента типа «Точка» и
возвращать длину стороны, формула для расчета d = √(x2 − x1)2 + (y2 − y1)2 и метод для
расчета периметра фигуры (подсказка – в методе циклом перебирать массив «Точек», пока в нем
будут элементы, и рассчитывать длину стороны). В методе Main() создать и рассчитать периметр
треугольника, квадрата, прямоугольника, точки выбрать произвольные.
 */

namespace _05_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point(4, 5, "A");
            Point b = new Point(3, 6, "B");
            Point c = new Point(1, 7, "C");
            Point d = new Point(3, 1, "D");

            Figure triangle = new Figure(a, b, c);
            Figure quadrilateral = new Figure(a, b, c, d);
            Figure square = new Figure(
                new Point(1, 1, "A"), 
                new Point(-1, 1, "B"), 
                new Point(-1, -1, "C"), 
                new Point(1, -1, "D"));

            Figure.GetPointInfo(triangle);
            Console.WriteLine("Perimetr");
            Console.WriteLine(triangle.GetPerimeter());

            Figure.GetPointInfo(quadrilateral);
            Console.WriteLine("Perimetr");
            Console.WriteLine(quadrilateral.GetPerimeter());

            Figure.GetPointInfo(square);
            Console.WriteLine("Perimetr");
            Console.WriteLine(square.GetPerimeter());

            Console.ReadLine();
        }

        class Point
        {
            private int x, y;
            private string pointName;

            public int X { get { return x; } set { x = value; } }
            public int Y { get { return y; } set { y = value; } }
            public string PointName { get { return pointName; } set { pointName = value; } }
            public Point(int x, int y, string pointName)
            {
                X = x;
                Y = y;  
                PointName = pointName;
            }
        }

        class Figure
        {
            Point[] figurePoints;
            private string figureName;

            public Point[] FigurePoints { get { return figurePoints; } private set { } }
            public string FigureName { get { return figureName; } private set { } }

            public Figure(Point a, Point b, Point c)
            {
                figurePoints = new Point[]{ a, b, c};
                figureName = "Triangle";
            }
            public Figure(Point a, Point b, Point c, Point d) : this(a, b, c)
            {
                figurePoints = new Point[] { a, b, c, d };
                figureName = "Quadrilateral";
            }

            private double SideLength(Point a, Point b)
            {
                return Math.Sqrt(Math.Pow((b.X - a.X), 2) + Math.Pow((b.Y - a.Y), 2));
            }

            public double GetPerimeter()
            {
                double result = 0;
                for (int i = 0; i < figurePoints.Length - 1; i++)
                {
                    result += SideLength(figurePoints[i], figurePoints[i + 1]);
                }

                return result;
            }

            public static void GetPointInfo(Figure figure)
            {
                Console.WriteLine(figure.FigureName);
                foreach (var item in figure.FigurePoints)
                {
                    Console.WriteLine($"{item.PointName}: {item.X}, {item.Y}");
                }
            }
        }
    }
}
