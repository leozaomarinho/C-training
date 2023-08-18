using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upcasting.Entities
{
    internal class BusinessAccount
    {
        public Double LoanLimit { get; set; }

        public BusinessAccount() { 
        }
        public BusinessAccount(Double loanLimit) : base() { }
    }
}
