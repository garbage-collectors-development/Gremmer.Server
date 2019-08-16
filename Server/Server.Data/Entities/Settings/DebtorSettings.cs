using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Data.Entities.Settings
{
    public class DebtorSettings
    {
        public int DaysToPay { get; set; }

        public int DaysBetweenReminders { get; set; }
    }
}
