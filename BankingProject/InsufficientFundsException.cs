using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject
{
    class InsufficientFundsException : Exception
    {
        public InsufficientFundsException() 
            : base() { }

        public InsufficientFundsException (string Message)
            : base(Message) { }
        
        public InsufficientFundsException (string Message, Exception InnerException)
            : base(Message, InnerException) { }
    }
}
