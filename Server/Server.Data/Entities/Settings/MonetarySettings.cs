using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Server.Data.Entities.Settings
{
    public class MonetarySettings
    {
        /// <summary>
        /// 
        /// </summary>
        [Key] public int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int MainCurrencyId { get; set; }

        /// <summary>
        /// All VAT values relevant for the company. The first index is the default choice. 
        /// </summary>
        public IList<uint> VatList { get; set; }

    }
}
