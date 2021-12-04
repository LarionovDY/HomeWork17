using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_17
{
    class BankAccount<T>
    {
        private string lastName;
        private string firstName;
        private string middleName;
        private T numberAccount;
        private decimal balance;
        public void Record(string lastName, string firstName, string middleName, T numberAccount, decimal balance)      //записывает данные счета в объект
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.middleName = middleName;
            this.numberAccount = numberAccount;
            this.balance = balance;
        }
        public void Print()
        {
            Console.WriteLine($"\nДанные счета:\nФамилия:{lastName}\nИмя:{firstName}\nОтчество:{middleName}\nНомер счета:{numberAccount}\nТекущий баланс:{balance:f2}");
        }       //выводит данные счета на консоль
        /*public void BalanceChanger()
        {
            Console.WriteLine("Если вы хотите пополнить счет нажмите '+' , для снятия денег со счета нажмите '-' ");
            ConsoleKey consolekey = Console.ReadKey().Key;
            decimal value;
            while (true)
            {
                switch (consolekey)
                {
                    case ConsoleKey.Add:
                        value = ReadDecValue("Введите сумму пополнения:");
                        balance += value;
                        Console.WriteLine();
                        break;
                    case ConsoleKey.Subtract:
                        value = ReadDecValue("Введите сумму снятия:");
                        balance -= value;
                        break;
                    default:
                        Console.WriteLine("Неверный ввод");
                        break;
                }
            }
        }*/
        public void BalanceAdd(decimal value)        //пополнение счета
        {
            balance += value;
        }

        public void BalanceSub(decimal value)        //снятие со счета
        {
            balance -= value;
        }        
    }
}
