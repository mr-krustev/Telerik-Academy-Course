using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Accounts.Types
{
    using BankAccounts.Interfaces;

    public class DepositAccount : Account, IDepositable, IWithdrawable
    {
        public DepositAccount(double balance, double interestRate, Customer customer)
            :base(balance,interestRate,customer)
        {      
        }

        public override void Deposit(double money)
        {
            this.Balance = this.Balance + money;
        }

        public void Withdraw(double money)
        {
            this.Balance = this.Balance - money;
        }

        public override double CalculateInterest(int months)
        {
            if (this.Balance < 1000)
            {
                Console.WriteLine("Deposit accounts don't have interest if balance is less than 1000.");
                return 0;
            }
            return (this.InterestRate * months);
        }

        public override string ToString()
        {
            return string.Format("Deposit account. \nCustomer {0} \nBalance: {1:C} \nInterest rate: {2:F2}",this.Customer.CustomerType, this.Balance, this.InterestRate);
        }
    }
}
