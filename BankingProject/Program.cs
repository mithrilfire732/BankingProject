using System;

namespace BankingProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var acct1 = new Account()
            {
                Id = 1,
                Description = "Test Account"
            };
            //acct1.Print();
            acct1.Deposit(135);
            //acct1.Print();
            acct1.Withdraw(-50);
            acct1.Print();
            var acct2 = new Account()
            {
                Id = 2,
                Description = "New Account"
            };
            acct1.Transfer(-25, acct2);
            acct1.Print();
            acct2.Print();

        }
    }
}
