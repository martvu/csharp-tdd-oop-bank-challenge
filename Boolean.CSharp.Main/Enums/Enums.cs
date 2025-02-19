﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Main.Enums
{
    public enum Branch
    {
        Oslo,
        Stockholm,
        London,
        Trondheim,
        Bournemouth
    }

    public enum TransactionType
    {
        Credit,
        Debit
    }

    public enum AccountType
    {
        Current,
        Saving,
    }

    public enum RequestStatus
    {
        Pending,
        Approved,
        Rejected
    }
}
