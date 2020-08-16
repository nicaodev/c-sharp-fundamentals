using System;
using System.Collections.Generic;
using System.Text;

namespace Sobreposicao.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }

        public Account()
        {
                
        }
        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void Withdraw (double amount) //Com virtual pode ser sobreescrito/sobreposto nas classes que herdam esta superclasse.
        {
            Balance -= amount + 5.0; //Com taxa de saque
        }
        public void Deposit(double amount)
        {
            Balance += amount;
        }

    }
}
