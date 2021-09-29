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
                Console.WriteLine("Deposit amount must be positive");
                return false;
            }
                this.Balance += Amount;
            return true;
        }

        public bool Withdraw(decimal Amount)
        {
            if(Amount > this.Balance)
            {
                Console.WriteLine("Insufficient Funds");
                return false;
            }
            if(Amount < 0)
            {
                Console.WriteLine("Withdrawal amount must be positive");
                return false;
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
