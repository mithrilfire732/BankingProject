using System;

namespace BankingProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //var n = 1;
            //var d = 0;
            //try
            //{
            //    var x = n / d;

            //} catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Divide by zero avoided");
            //}





            var acct1 = new Savings()
            {
                Id = 1,
                Description = "My first savings"
            };

            var acct2 = new Account()
            {
                Id = 2,
                Description = "New Account"
            };

            var sav2 = new Savings2(100);
            sav2.Description = ("Alexander Savings");
            sav2.InterestRate = 0.12m;
            
            try {
            acct1.Deposit(6000);
            sav2.Deposit(5000);
            sav2.Withdraw(6000);
            sav2.CalculateAndPayInterest(1);
            acct1.Transfer(2500, acct2);
            }
            catch(AmountGreaterThanZeroException ex)
            {
                Console.WriteLine("Amount cannot be zero or negative");
            } catch(InsufficientFundsException ex)
            {
                Console.WriteLine("You don't have enough in your account, whoops.");
                Console.WriteLine($"You have ${ex.CurrentBalance} in your account");
                Console.WriteLine($"You are attempting to withdraw ${ex.AmountToWithdraw}");
            }catch(Exception ex)
            {
                Console.WriteLine("You broke it, congrats.");
            }
            //sav2.Print();
            //acct1.Print();
            //acct2.Print();
        }
    }
}
