using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Data.Entities.Settings
{
    public class LoginSettings
    {
        public int Id { get; set; }

        /// <summary>
        /// Corresponding customer ID.
        /// </summary>
        public int CustomerId { get; set; }

        /// <summary>
        /// Allow all user to login using email.
        /// </summary>
        public bool AllowEmailLogin { get; set; } = true;

        /// <summary>
        /// Allow user to login using username. 
        /// </summary>
        public bool AllowUsernameLogin { get; set; } = true;

        /// <summary>
        /// Only allow the ip addresses in IpList to be logged in from. 
        /// </summary>
        public bool ApplyIpProtection { get; set; } = false;

        /// <summary>
        /// List of all allowed ip addresses.
        /// </summary>
        public virtual IList<uint> IpList { get; set; }

    }
}
