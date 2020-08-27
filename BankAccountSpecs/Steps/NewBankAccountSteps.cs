using BankingDomain;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using Xunit;

namespace BankAccountSpecs.Steps
{
    [Binding]
    public class NewBankAccountSteps
    {
        StandardBankAccountContext _context;

       

        public NewBankAccountSteps(StandardBankAccountContext context)
        {
            _context = context;
        }

        [Given(@"I have created a new Bank Account")]
        public void GivenIHaveCreatedANewBankAccount()
        {
            // we built in the context.
        }

        [When(@"I retrieve the balance")]
        public void WhenIRetrieveTheBalance()
        {
            
        }

        [Then(@"the balance should be ""(.*)""")]
        public void ThenTheBalanceShouldBe(Decimal expected)
        {
            Assert.Equal(expected, _context.Account.GetBalance());
        }
       


    }
}
