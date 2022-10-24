using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Account : Person
    {
        //Constructor
        public Account() { }
        //Methods
        public double getAccountBalance()
        {
            return currentAccount;
        }
        public double setAccountBalance(double amount)
        {
            currentAccount = currentAccount + amount;
            return currentAccount;
        }
        public double withdrawFromAcccount(double amountToWithdraw)
        {
            currentAccount = currentAccount - amountToWithdraw;
            return currentAccount;
        }
    }
}
