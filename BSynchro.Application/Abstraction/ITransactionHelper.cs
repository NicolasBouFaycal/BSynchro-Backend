﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSynchro.Application.Abstraction
{
    public interface ITransactionHelper
    {
        public void TransactionMade(int accountId, int initialCredit);

    }
}
