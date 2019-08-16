using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Server.Data.Entities.Debtors
{
    public class Order
    {
        [Key] public int Id { get; set; }

        /// <summary>
        /// Date associated with the order.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Description of order.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Total amount to pay.
        /// </summary>
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalAmount { get; set; }

        /// <summary>
        /// Total amount paid.
        /// </summary>
        [Column(TypeName = "decimal(2,2)")]
        public decimal? VatPercentage { get; set; }
    }
}
