using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Sobreposicao.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }


        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public override void Withdraw(double amount) //Sobreescrevendo a função herdada
        {
            Balance -= amount; // Sem taxa de saque.
        }
    }
}
