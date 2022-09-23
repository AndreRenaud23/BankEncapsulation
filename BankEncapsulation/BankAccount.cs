using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    internal class BankAccount
    {
        private double balance = 0;

        public double Deposit(double userDepositAnswer)
        {
            
            return balance += userDepositAnswer;
        }

        public double Withdraw(double userWithdrawAnswer)
        {
            return balance -= userWithdrawAnswer;
        }
        public double GetBalance()
        {
            return balance;
        }

    }
}
