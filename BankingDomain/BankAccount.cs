using System;

namespace BankingDomain
{
    public class BankAccount
    {
        private decimal _balance = 1000;
        public decimal GetBalance()
        {
            return _balance;
        }

        public void Deposit(decimal amountToDeposit)
        {
            _balance += amountToDeposit;
        }
    }
}