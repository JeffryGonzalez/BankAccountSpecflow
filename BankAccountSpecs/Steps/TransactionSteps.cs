using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace BankAccountSpecs.Steps
{
    [Binding]
    public sealed class TransactionSteps
    {

        StandardBankAccountContext _context;

        public TransactionSteps(StandardBankAccountContext context)
        {
            _context = context;
        }

        [When(@"I deposit ""(.*)""")]
        public void WhenIDeposit(decimal amountToDeposit)
        {
            _context.Account.Deposit(amountToDeposit);
        }



    }
}
