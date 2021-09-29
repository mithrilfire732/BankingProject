using System;

namespace BankingProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var sav2 = new Savings2(100);
            sav2.Description = ("Alexander Savings");
            sav2.InterestRate = 0.12m;
            sav2.Print();
            sav2.Deposit(5000);
            sav2.Withdraw(2000);
            sav2.CalculateAndPayInterest(1);
            sav2.Print();


            //var acct1 = new Savings()
            //{
            //    Id = 1,
            //    Description = "My first savings"
            //};
            //acct1.Deposit(6000);
            //var acct2 = new Account()
            //{
            //    Id = 2,
            //    Description = "New Account"
            //};
            //acct1.Transfer(25, acct2);
            //acct1.Print();
            //acct2.Print();
        }
    }
}
