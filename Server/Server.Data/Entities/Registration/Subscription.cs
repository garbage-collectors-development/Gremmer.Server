using System;
using System.Collections.Generic;
using System.Text;

namespace Gremmer.Data.Entities.Registration
{
    public class Subscription
    {
        /// <summary>
        /// Unique ID of subscription.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Corresponding customer's id. 
        /// </summary>
        public int CustomerId { get; set; }

        /// <summary>
        /// Type of the subscription. 
        /// </summary>
        public SubscriptionTypes SubScripsSubscriptionType { get; set; }

        /// <summary>
        /// Corresponding DateTime of start of the subscription 
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Returns the duration of the subscriptions in days.
        /// </summary>
        public uint Duration { get; set; }

        // Do we want this to be hardcoded?? Also, this must be placed in another file but CBA. 
        /// <summary>
        /// All types of subscriptions.
        /// </summary>
        public enum SubscriptionTypes
        {
            Free,
            Trial,
            Premium
        }

    }
}
