using System;
using System.Collections.Generic;
using System.Text;

namespace BankAcc
{
    class Savings : Account
    {
        public override void Deposit(int amount)
        {
            this.Balance += amount;
        }


        public override Boolean Withdraw(int amount)
        {
            if (this.Balance < amount)
            {
                return false;
            }
            else
            {
                this.Balance -= amount;
                return true;
            }
        }
    }
}
