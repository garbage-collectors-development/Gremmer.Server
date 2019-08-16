using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Server.Data.Entities.Registration
{
    public class Subscription
    {
        /// <summary>
        /// GUID of subscription.
        /// </summary>
        [Key] public Guid Id { get; set; }

        /// <summary>
        /// Corresponding customer's id. 
        /// </summary>
        public int CustomerId { get; set; }

        /// <summary>
        /// Reference to the ID of the subscriptiontype. 
        /// </summary>
        public int SubscriptionType { get; set; }

        /// <summary>
        /// Corresponding DateTime of start of the subscription. 
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Corresponding DateTime of end of the subscription.
        /// </summary>
        public DateTime EndDate { get; set; }
        
    }
}
