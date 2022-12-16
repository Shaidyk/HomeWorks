using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
Напишите программу русско-английский переводчик. Программа знает 10 слов о погоде. Требуется,
чтобы пользователь вводил слово на русском языке, а программа давала ему перевод этого слова
на английском языке. Если пользователь ввел слово, для которого отсутствует перевод, то следует
вывести сообщение, что такого слова нет.
 */

namespace _9_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter word: ");
                string userWord = Console.ReadLine();
                string[] vords = { "rain", "sun", "cloud", "snow", "wind", "cold", "hot", "fog", "warm", "freezing" };
                if (!vords.Contains(userWord))
                {
                    Console.WriteLine("I dont know this word");
                }
                else
                {
                    switch (userWord)
                    {
                        case "rain":
                            Console.WriteLine("Дождь");
                            break;
                        case "sun":
                            Console.WriteLine("Солнечно");
                            break;
                        case "cloud":
                            Console.WriteLine("Облочно");
                            break;
                        case "snow":
                            Console.WriteLine("Снегш");
                            break;
                        case "wind":
                            Console.WriteLine("Ветер");
                            break;
                        case "cold":
                            Console.WriteLine("Холодно");
                            break;
                        case "hot":
                            Console.WriteLine("Жарко");
                            break;
                        case "fog":
                            Console.WriteLine("Туман");
                            break;
                        case "warm":
                            Console.WriteLine("Тепло");
                            break;
                        case "freezing":
                            Console.WriteLine("Мороз");
                            break;
                    }
                }
            }
        }
    }
}
