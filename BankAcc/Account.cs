using System;
using System.Collections.Generic;
using System.Text;

namespace BankAcc
{
    public abstract class Account
    {
        private String accName;
        private String acId;
        private int balance;

        public String AccName { get { return accName; } set { accName = value; } }
        public String AcId { get { return acId; } set { acId = value; } }
        public int Balance { get { return balance; } set { balance = value; } }

        public Account()
        {
        }

        public Account(String accName, String acId, int balance)
        {
            this.accName = accName;
            this.acId = acId;
            this.balance = balance;
        }

        public abstract void Deposit(int amount);

        public abstract Boolean Withdraw(int amount);

        public Boolean transfer(int amount, Account receiver)
        {
            if (this.balance < amount)
            {
                return false;
            }
            else
            {
                if (receiver != null)
                {
                    receiver.balance += amount;
                    this.balance -= amount;
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
