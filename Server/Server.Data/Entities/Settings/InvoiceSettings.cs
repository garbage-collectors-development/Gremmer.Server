using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Server.Data.Entities.Settings
{
    public class InvoiceSettings
    {
        [Key] public int Id { get; set; }

        public int Company { get; set; }

        public int DefaultDaysToPay { get; set; }

        public int DefaultDaysBetweenReminders { get; set; }

    }
}
