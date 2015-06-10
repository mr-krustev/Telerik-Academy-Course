using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Accounts
{
    public enum CustomerType
    {
        Individual,
        Company
    }

    public class Customer
    {
        // This could also contain lots of customer information - Name, Age, etc. For this task however it is not needed.
        private CustomerType customerType;

        public Customer(CustomerType customerType)
        {
            this.CustomerType = customerType;
        }

        public CustomerType CustomerType
        {
            get { return this.customerType; }
            private set { this.customerType = value; }
        }
    }
}
