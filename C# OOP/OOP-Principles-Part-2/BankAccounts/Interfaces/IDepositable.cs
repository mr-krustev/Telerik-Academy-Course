﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Interfaces
{
    public interface IDepositable
    {
        void Deposit(double money);
    }
}
