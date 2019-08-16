using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Server.Data.Entities.Registration
{
    public class Address
    {
        /// <summary>
        /// 
        /// </summary>
        [Key] public int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Address1 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Address2 { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string PostalCode { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string District { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int Country { get; set; }

    }
}
