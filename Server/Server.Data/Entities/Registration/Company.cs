using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Data.Entities.Registration
{
    /// <summary>
    /// A customer can have multiple companies linked to its profile.
    /// </summary>
    public class Company
    {
        /// <summary>
        /// Unique ID of company.
        /// </summary>
        public int Id { get; set;  }

        /// <summary>
        /// Name of the company.
        /// </summary>
        public string Name { get; set;  }
        
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
        /// 
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Customer's main E-Mail address.
        /// </summary>
        public string Email { get; set; }
    }
}
