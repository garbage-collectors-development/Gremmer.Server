using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Server.Data.Entities.Debtors
{
    public class SalesInvoice
    {
        [Key] public int Id { get; set; }

        /// <summary>
        /// Reference to the id of debtor.
        /// </summary>
        public int Debtor { get; set; }

        /// <summary>
        /// List of orders, displayed in the invoice on seperate lines. Together they form total vat, total amount to pay, etc. 
        /// </summary>
        public List<int> Orders { get; set; }

        /// <summary>
        /// Date of creation of the invoice.
        /// </summary>
        public DateTime InvoiceDate { get; set; }

        /// <summary>
        /// Date that the invoice is due.
        /// </summary>
        public DateTime DueDate { get; set; }
    }
}
