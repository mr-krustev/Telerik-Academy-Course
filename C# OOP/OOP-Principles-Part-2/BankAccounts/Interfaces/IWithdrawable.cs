﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Interfaces
{
    interface IWithdrawable
    {
        void Withdraw(double money);
    }
}
