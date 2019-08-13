namespace Server.Data.Entities.Debtors
{
    public class Debtor
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Address2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string PostalCode { get; set; }

        /// <summary>
        /// Country ID
        /// </summary>
        public int CountryId { get; set; }

        /// <summary>
        /// 
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
    }
}
