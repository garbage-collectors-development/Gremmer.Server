using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Server.Data.Entities.Creditors
{
    public class Creditor
    {
        /// <summary>
        /// 
        /// </summary>
        [Key] public int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? Address { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<int> Contacts { get; set; }

    }
}
