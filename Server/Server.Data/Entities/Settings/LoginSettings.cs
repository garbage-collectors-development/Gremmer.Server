using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Server.Data.Entities.Settings
{
    public class LoginSettings
    {
        [Key] public int Id { get; set; }

        /// <summary>
        /// Corresponding customer ID.
        /// </summary>
        public int CustomerId { get; set; }

        /// <summary>
        /// Allow all user to login using email.
        /// </summary>
        public bool AllowEmailLogin { get; set; } 

        /// <summary>
        /// Allow user to login using username. 
        /// </summary>
        public bool AllowUsernameLogin { get; set; } 

        /// <summary>
        /// Only allow the ip addresses in IpList to be logged in from. 
        /// </summary>
        public bool ApplyIpProtection { get; set; } 

        /// <summary>
        /// List of all allowed ip addresses.
        /// </summary>
        public virtual IList<uint> IpList { get; set; }

    }
}
