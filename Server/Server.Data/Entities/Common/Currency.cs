using System;
using System.Collections.Generic;
using System.Text;

namespace Gremmer.Data.Entities.Common
{
    // Should this be in the database, or should we hardcode those currencies with all this information? 
    public class Currency
    {
        public int Id { get; set; }

        /// <summary>
        /// The actual name of the currency, such as Euro.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The commonly used abbreviation for the currency, such as EUR.
        /// </summary>
        public string Abbreviation { get; set; }

        /// <summary>
        /// The widely accepted symbol for the currency, such as €.
        /// </summary>
        public char Symbol { get; set; }
    }
}
