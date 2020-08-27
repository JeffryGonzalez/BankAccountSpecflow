using BankingDomain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccountSpecs.Steps
{
    public class StandardBankAccountContext
    {

        public StandardBankAccountContext()
        {
            this.Account = new BankAccount(/* pass in whatever you need here. */);
        }

        public BankAccount Account { get; }
    }
}
