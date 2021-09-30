using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject
{
    class Account
    {
        public int Id { get; set; }
        public decimal Balance { get; set; } = 0;
        public string Description { get; set; }
        
        public bool Deposit(decimal Amount)
        {
            if (Amount < 0)
            {
                throw new AmountGreaterThanZeroException();
            }
                this.Balance += Amount;
            return true;
        }

        public bool Withdraw(decimal Amount)
        {
            if(Amount > this.Balance)
            {
                throw new InsufficientFundsException();
            }
            if(Amount <= 0)
            {
                throw new AmountGreaterThanZeroException();
            }
            this.Balance += -Amount;
            return true;
        }
        public bool Transfer(decimal Amount, Account ToAccount)
        {
            var success = Withdraw(Amount);
            if (success)
            {
                ToAccount.Deposit(Amount);
            }
            return true;
        }
        public void Print()
        {
            Console.WriteLine($"{Id} | {Balance} | {Description}");
        }
    }
}
