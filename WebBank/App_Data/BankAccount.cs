using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebBank
{
    public class BankAccount
    {
        public int accountNumber;
        public float balance;

        public BankAccount()
        {
            this.accountNumber = 456789876;
            this.balance = 0;
        
        }

        public void Deposit(float amount)
        {
            this.balance += amount;
        }

        public void Transfer(BankAccount destination, float payment)
        {
            this.balance -= payment;
            destination.balance += payment;
        }

    }
}