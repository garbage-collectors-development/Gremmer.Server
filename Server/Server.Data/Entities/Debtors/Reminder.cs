using System;
using System.Collections.Generic;

namespace Server.Data.Entities.Debtors
{
    public class Reminder
    {
        public int Id { get; set; }

        /// <summary>
        /// Id of corresponding creditor.
        /// </summary>
        public int CreditorId { get; set; }

        /// <summary>
        /// This list contains all ID's of the invoices being reminded.
        /// </summary>
        public IList<int> InvoiceList { get; set; }

        /// <summary>
        /// DateTime of reminder's creation timestamp.
        /// </summary>
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool IsReminderAutomaticallySent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool IsReminderPrinted { get; set; }


    }
}
