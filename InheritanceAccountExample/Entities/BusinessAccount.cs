using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAccountExample.Entities
{
    class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccount(int number, string holder, double balance, double loanLimit)
            : base (number, holder, balance)
        {
            this.LoanLimit = loanLimit;
        }

        public void Load(double amount)
        {
            if (amount <= LoanLimit)
                this.Balance += amount;
        }
    }
}
