using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте программу в которой создайте класс «Адрес».
В теле класса создайте следующие поля: страна, город, улица, дом, квартира, индекс.
Для каждого поля, создать свойство с двумя методами доступа. Также в классе необходимо
создать метод для отображения информации про адрес. В методе Main() создайте экземпляр
класса «Адрес», присвойте всем полям значение через свойства доступа, а также на экземпляр
класса вызовите метод, который выводит информацию про адрес.
 */

namespace _01_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Adres adr = new Adres();
            adr.Country = "Ukraine";
            adr.City = "Vinnitsa";
            adr.Street = "Soborna";
            adr.Home = "123a";
            adr.Flat = "14b";
            adr.Index = 123456;

            adr.GetInfo();

            Console.ReadLine();
        }
    }

    class Adres
    {
        string country;
        string city;
        string street;
        string home;
        string flat;
        int index;

        public string Country { get { return country; } set { country = value; } }
        public string City { get { return city; } set { city = value; } }
        public string Street { get { return street; } set { street = value; } }
        public string Home { get { return home; } set { home = value; } }
        public string Flat { get { return flat; } set { flat = value; } }
        public int Index { get { return index; } set { index = value; } }

        public void GetInfo()
        {
            Console.WriteLine($"Country: {Country}");
            Console.WriteLine($"City: {City}");
            Console.WriteLine($"Street: {Street}");
            Console.WriteLine($"Home: {Home}");
            Console.WriteLine($"Flat: {Flat}");
            Console.WriteLine($"Index: {Index}");
        }
    }
}
