using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Accounts.Types
{
    using BankAccounts.Interfaces;

    public class LoanAccount : Account, IDepositable
    {

        public LoanAccount(double balance, double interestRate, Customer customer)
            : base(balance, interestRate, customer)
        {
        }


        public override void Deposit(double money)
        {
            this.Balance = this.Balance + money;
        }

        public override double CalculateInterest(int months)
        {
            switch (this.Customer.CustomerType)
            {
                case CustomerType.Individual:
                    if (DateTime.Now.Month - this.DayOfRegistration.Month < 3 && DateTime.Now.Year == this.DayOfRegistration.Year)
                    {
                        Console.WriteLine("Loan accounts have no interest for the first 3 months.");
                        return 0;
                    }
                    else
                    {
                        return (this.InterestRate * months);
                    }
                case CustomerType.Company:
                    if (DateTime.Now.Month - this.DayOfRegistration.Month < 2 && DateTime.Now.Year == this.DayOfRegistration.Year)
                    {
                        Console.WriteLine("Loan accounts have no interest for the first 3 months.");
                        return 0;
                    }
                    else
                    {
                        return (this.InterestRate * months);
                    }
                default:
                    throw new ArgumentException();
            }
        }

        public override string ToString()
        {
            return string.Format("Loan account. \nCustomer: {0} \nBalance: {1:C} \nInterest rate: {2:F2}",this.Customer.CustomerType, this.Balance, this.InterestRate);
        }
    }
}
