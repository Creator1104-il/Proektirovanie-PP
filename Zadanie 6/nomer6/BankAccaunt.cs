using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nomer6
{
    internal class BankAccaunt
    {
        public string accountNumber;
        public double balance = 0;

        public void Deposit(double amount)
        {
            balance += amount;
            Console.WriteLine($"Внесено {amount}. Текущий баланс: {balance}");
        }

        public void Withdraw(double amount)
        {
            if (amount > balance)
                Console.WriteLine("Недостаточно средств");
            else
            {
                balance -= amount;
                Console.WriteLine($"Снято {amount}. Текущий баланс: {balance}");
            }
        }
    }
}
