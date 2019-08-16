using System.ComponentModel.DataAnnotations;

namespace Server.Data.Entities.Creditors
{
    public class PurchaseInvoice
    {
        /// <summary>
        ///  
        /// </summary>
        [Key] public string InvoiceNumber { get; set; }

        public int Creditor { get; set; }

        
    }
}
