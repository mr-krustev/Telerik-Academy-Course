using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Accounts.Types
{
    using BankAccounts.Interfaces;

    public class MortgageAccount : Account, IDepositable
    {
        public MortgageAccount(double balance, double interestRate, Customer customer)
            :base(balance,interestRate,customer)
        {      
        }

        public override void Deposit(double money)
        {
            this.Balance = this.Balance + money;
        }
        
        public override double CalculateInterest(int months)
        {
            switch (Customer.CustomerType)
            {
                case CustomerType.Individual:
                    if (DateTime.Now.Month - this.DayOfRegistration.Month < 12 && DateTime.Now.Year == this.DayOfRegistration.Year)
                    {
                        return (this.InterestRate * months) / 2;
                    }
                    return (this.InterestRate * months);

                case CustomerType.Company:
                    if (DateTime.Now.Month - this.DayOfRegistration.Month < 6 && DateTime.Now.Year == this.DayOfRegistration.Year)
                    {
                        Console.WriteLine("Mortgage accounts don't have interest for the first 6 months for individuals.");
                        return 0;
                    }
                    return (this.InterestRate * months);
                default:
                    throw new ArgumentException();
            }
            
        }
        
        public override string ToString()
        {
            return string.Format("Mortgage account. \nCustomer: {0} \nBalance: {1:C} \nInterest rate: {2:F2}",this.Customer.CustomerType, this.Balance, this.InterestRate);
        }
    }
}
