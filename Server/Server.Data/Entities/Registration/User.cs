using System;
using System.Collections.Generic;
using System.Text;

namespace Gremmer.Data.Entities.Registration
{
    public class User
    {
        /// <summary>
        ///  
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public int CompanyId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Nickname { get; set; }
        
        /// <summary>
        /// Username of user which may not contain a '@'. 
        /// </summary>
        public string Username { get; set; }
        
        /// <summary>
        /// E-Mail address of user used to login
        /// </summary>
        public string Email { get; set; }
        
        /// <summary>
        /// Hashed pass phrase of the customer.
        /// </summary>
        public string HashedPassPhrase { get; set; }
    }
}
