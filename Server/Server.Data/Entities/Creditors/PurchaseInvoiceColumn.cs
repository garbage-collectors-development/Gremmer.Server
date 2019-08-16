using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Data.Entities.Creditors
{
    /// <summary>
    /// A creditor invoice can be seperated in columns, because some invoices
    /// contain orders for different accounts. 
    /// </summary>
    public class PurchaseInvoiceColumn
    {

        public string Description { get; set; }

        /// <summary>
        /// A reference to the CostGroup ID
        /// </summary>
        public int CostGroup { get; set; }
        
        /// <summary>
        /// Account in the general ledger that this column is dedicated to
        /// </summary>
        public int Account { get; set; }



        public decimal NetAmount { get; set; }
    }

}
