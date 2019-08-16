using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Server.Data.Entities.Debtors
{
    public class Debtor
    {
        [Key] public int Id { get; set; }

        public int DebtorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? Address { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string PhoneNumber { get; set; }

        public List<int> Contacts { get; set; }

        /// <summary>
        /// Company Registry Number, such as KVK (Netherlands)
        /// </summary>
        public string RegistryNumber { get; set; }

        /// <summary>
        /// Company's Taxpayer Identification Number (TIN) which is used for tax purposes. 
        /// </summary>
        public string TaxpayerIdentificationNumber { get; set; }
    }
}
