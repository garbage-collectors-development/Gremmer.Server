using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Server.Data.Entities.Registration
{
    /// <summary>
    /// A customer can have multiple companies linked to its profile.
    /// </summary>
    public class BusinessUnit
    {
        /// <summary>
        /// Unique ID of company.
        /// </summary>
        [Key] public int Id { get; set;  }

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
        /// Companies default phonenumber.
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Companies default E-Mail address.
        /// </summary>
        public string Email { get; set; }

    }
}
