using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject
{
    class Savings : Account
    {
        public decimal InterestRate { get; set; } = 0.01m; // "m" behind the number to indicate it is a decimal not double

        decimal CalculateInterest(int months)
        {
            var interest = Balance * (InterestRate / 12)* (months); //does not compound, calculates simple interest
            Deposit(interest);   // calls inherited method to deposit interest
            return interest;
        }
    }
}
