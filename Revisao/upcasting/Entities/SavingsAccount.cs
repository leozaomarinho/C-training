﻿

namespace upcasting.Entities
{
    internal class SavingsAccount : Account
    {
        public double InterestRate { get; set; }


        public SavingsAccount() { 
        
        }

        public SavingsAccount( int number, string holder, double balance, double interestRate)
            : base(number,holder,balance)
        {
            InterestRate = interestRate;


        }

        public void UpdateBalance() {
            Balance += Balance * InterestRate;
        
        }

        public override void WithDraw(double amount)
        {
            Balance -=amount;

            base.Deposit(amount);
        }
    }
}
