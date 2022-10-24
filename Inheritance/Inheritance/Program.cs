using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate Account class
            Account myAccount = new Account();

            //save money in current account
            double currentAmount = 0.0;
            currentAmount = myAccount.setAccountBalance(1000.00);
            Console.WriteLine("current amount: {0}", currentAmount);

            //withdraw 200.00
            currentAmount = myAccount.withdrawFromAcccount(200.00);
            Console.WriteLine("current amount: {0}", currentAmount);

            //get balance
            currentAmount = myAccount.getAccountBalance();
            Console.WriteLine("current amount: {0}", currentAmount);
            Console.ReadLine();
        }
    }
}
