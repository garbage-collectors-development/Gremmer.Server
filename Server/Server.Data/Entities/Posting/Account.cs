using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Data.Entities.Posting
{
    /// <summary>
    /// Account is part of the general ledger
    /// </summary>
    public class Account
    {

        /// <summary>
        /// AccountType indicates whether this account is visible on the balance sheet or on the income statement.
        /// 0 = Balance sheet and 1 = income statement.
        /// </summary>
        public int AccountType { get; set; }
    }
}
