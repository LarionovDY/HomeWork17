using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_17
{
    //Создать класс для моделирования счета в банке.Предусмотреть закрытые поля для номера счета, баланса, ФИО владельца.
    //Класс должен быть объявлен как обобщенный.Универсальный параметр T должен определять тип номера счета.
    //Разработать методы  для доступа  к данным  –  заполнения и  чтения.
    //Создать несколько экземпляров класса, параметризированного различными типам.
    //Заполнить его поля и вывести информацию об экземпляре класса на печать.
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount<long> account1 = new BankAccount<long>();
            BankAccount<string> account2 = new BankAccount<string>();
            account1.Print();
            account2.Print();
            account1.Record("Иванов", "Иван", "Иванович", 4815162342, (decimal)323453.43);
            account2.Record("Сидорова", "Анна", "Николаевна", "DS34523484" , (decimal)0.45);
            account1.Print();
            account2.Print();
            account1.BalanceSub(200000);
            account2.BalanceAdd(200000);
            account1.Print();
            account2.Print();
            Console.ReadKey();
        }        
    }
    

}
