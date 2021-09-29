using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject
{
    class Savings2
    {
        private Account account { get; set; }  // creates a property of Savings2 which is an instance of class account

        public int Id => account.Id;            // properties of Savings mapped to account attributes vvv
        public decimal Balance => account.Balance;
        public string Description {
            get { return account.Description; }
            set { account.Description = value; }   // value is a keyword that indicates whatever is on the right side when user changes value
        }

        public decimal InterestRate { get; set; } = 0.01m;

        public decimal CalculateAndPayInterest(int months)
        {
            var interest = this.account.Balance * (InterestRate / 12) * months;
            this.account.Deposit(interest);
            return interest;
        }
        public bool Deposit(decimal amount)
        {
            return this.account.Deposit(amount);
        }
        public bool Withdraw(decimal amount)
        {
            return this.account.Withdraw(amount);
        }
        public bool Transfer(decimal amount, Account ToAccount)
        {
            return this.account.Transfer(amount, ToAccount);
        }

        public void Print()
        {
            this.account.Print();
        }
        
        public Savings2(int Id)
        {
            this.account = new Account();
            this.account.Id = Id;
            this.account.Description = "New Savings2";
        }
    }
}
