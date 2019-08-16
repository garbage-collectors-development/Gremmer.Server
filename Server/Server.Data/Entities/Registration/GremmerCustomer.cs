using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Server.Data.Entities.Registration
{
    /// <summary>
    /// The Customer is the customer of Gremmer.
    /// </summary>
    public class GremmerCustomer
    {
        /// <summary>
        /// Unique ID of OUR customer, main recovery account.
        /// </summary>
        [Key] public int Id { get; set; }

        /// <summary>
        /// Main email address to which reminders are being sent.
        /// </summary>
        public string Email { get; set; }
        
        /// <summary>
        /// Main phonenumber which is directly displayed in the debtors view.
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Company Registry Number, such as KVK (Netherlands)
        /// </summary>
        public string RegistryNumber { get; set; }

        /// <summary>
        /// Company's Taxpayer Identification Number (TIN) which is used for tax purposes. 
        /// </summary>
        public string TaxpayerIdentificationNumber { get; set; }

        /// <summary>
        /// List of references to the Contact ID's. 
        /// </summary>
        public List<int> Contacts { get; set; }
    }
}
