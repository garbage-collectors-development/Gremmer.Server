using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Server.Data.Entities.Registration
{
    /// <summary>
    /// A business contact of a customer.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// 
        /// </summary>
        [Key] public int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string MiddleName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Email { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int Address { get; set; }
    }
}
