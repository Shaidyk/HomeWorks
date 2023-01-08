using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте программу в которой создайте класс «Котенок».
В теле класса создайте следующие поля: имя, возраст, цвет шерсти, цвет глаз. Для каждого
поля, создать свойство с двумя методами доступа. Также в теле класса создайте метод, который
будет выводить на консоль «Мяу», метод должен принимать один аргумент – количество «Мяу»
котенка, выводить «Мяу» соответствующее количество раз. В методе Main() создайте экземпляр
класса «Котенок», присвойте всем полям значение через свойства доступа, а также вызовите
метод с помощью которого котенок говорит «Мяу», в качестве аргумента метода передайте 3.
 */

namespace _02_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.Name = "CAT";
            cat.Year = 2.5f;
            cat.FurColor = "Green";
            cat.EyeColor = "Yellow";

            cat.SayMeaw(3);

            Console.Read();
        }
    }

    class Cat
    {
        string name;
        float year;
        string furColor;
        string eyeColor;

        public string Name { get { return name; } set { name = value; } }
        public float Year { get { return year; } set { year = value; } }
        public string FurColor { get { return furColor; } set { furColor = value; } }
        public string EyeColor { get { return eyeColor; } set { eyeColor = value; } }

        public void SayMeaw(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write("Meaw...\t");
            }
        }
    }
}
