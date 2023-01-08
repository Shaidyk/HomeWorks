using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

/*
 Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте программу в которой создайте класс «Банковский Счет».
В теле класса создайте следующие поля: дата открытия счета, процентная ставка по счету,
сумма счета. В теле метода создайте следующие методы: Метод, который рассчитывает
количество дней, начиная с даты открытия счета; Метод который выводит информацию о
количестве рассчитанных дней; Метод который рассчитывает сумму, которая будет на счете
через определенное количество лет (количество лет – параметр метода); Метод который
выводит информацию о сумме. Также продумать над конструктором класса. В методе Main()
создайте экземпляр класса «Банковский Счет», присвойте всем полям значение через свойства
доступа, а также на экземпляр класса вызовите методы для отображения количества дней и
суммы.
 */

namespace _03_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount();
            bankAccount.AccountPercent = 10f;
            bankAccount.MoneyCount = 20000M;

            bankAccount.GetAccountAge();
            bankAccount.GetMoney();
            bankAccount.GetMoneyAfterYears(10);

            Console.ReadLine();
        }
    }

    class BankAccount
    {
        DateTime accountOpeningDate;
        float accountPercent;
        decimal moneyCount;

        public float AccountPercent { get { return accountPercent; } set { accountPercent = value; } }
        public decimal MoneyCount { get { return moneyCount; } set { moneyCount = value; } }

        public BankAccount()
        {
            this.accountOpeningDate = new DateTime(2010, 10, 24);
        }
        private int AccountAge()
        {
            return (DateTime.Today.Year - accountOpeningDate.Year) * 365;
        }

        public void GetAccountAge()
        {
            Console.WriteLine($"Your account age {AccountAge()} days");
        }

        public void GetMoney()
        {
            Console.WriteLine($"Your current modey {moneyCount}");
        }

        private decimal MoneyAfterYears(int years)
        {
            return moneyCount += (moneyCount * (decimal)(accountPercent / 100)) * years;
        }

        public void GetMoneyAfterYears(int years)
        {
            Console.WriteLine($"You will be have {MoneyAfterYears(years)} after {years} years"); 
        }
    }
}
