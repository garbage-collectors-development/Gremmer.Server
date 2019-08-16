using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Data.Entities.Settings
{
    public class CompanySettings
    {
        public int DefaultDaysToPay { get; set; }

        public int DefaultDaysBetweenReminders { get; set; }
    }
}
