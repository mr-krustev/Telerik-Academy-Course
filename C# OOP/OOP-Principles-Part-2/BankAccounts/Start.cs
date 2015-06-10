

namespace BankAccounts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Globalization;

    using Accounts;
    using Accounts.Types;

    class Start
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

            // Feel free to test. This could always be extended to check certain inputs.

            var bigTest = new List<Account>()
            {
                 new LoanAccount(12.00, 5,new Customer(CustomerType.Individual)),
                 new DepositAccount(100.00, 4, new Customer(CustomerType.Company)),
                 new MortgageAccount(1000.00, 6, new Customer(CustomerType.Individual))
            };

            foreach (var acc in bigTest)
            {
                Console.WriteLine(acc);
                Console.WriteLine("Current interest: " + acc.CalculateInterest(5));
                Console.WriteLine();
            }
        }
    }
}
