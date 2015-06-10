using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Accounts
{
    using BankAccounts.Interfaces;

    public abstract class Account : IDepositable
    {
        //All accounts have customer, balance and interest rate (monthly based).

        private Customer customer;
        private double balance;
        private double interestRate;
        private DateTime dayOfRegistration;

        public abstract double CalculateInterest(int months);

        public Account(double balance, double interestRate, Customer customer)
        {
            this.Balance = balance;
            this.InterestRate = interestRate;
            this.customer = customer;
            this.dayOfRegistration = DateTime.Now;  //Change this to test. E.g. DateTime.Parse("20.01.2015");  / DateTime.Parse("20.12.2014");
        }

        public Customer Customer
        {
            get { return this.customer; }
            set { this.customer = value; }
        }

        public double Balance
        {
            get { return this.balance; }
            protected set { this.balance = value; }
        }

        public double InterestRate
        {
            get { return this.interestRate; }
            private set { this.interestRate = value; }
        }

        public DateTime DayOfRegistration
        {
            get { return this.dayOfRegistration; }
            private set { this.dayOfRegistration = value; }
        }


        public abstract void Deposit(double money);
    }
}
