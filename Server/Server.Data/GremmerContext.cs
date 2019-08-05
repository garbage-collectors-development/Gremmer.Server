using System;
using System.Collections.Generic;
using System.Text;
using Gremmer.Data.Entities.Creditors;
using Gremmer.Data.Entities.Debtors;
using Gremmer.Data.Entities.Registration;
using Gremmer.Data.Entities.Settings;
using Microsoft.EntityFrameworkCore;

namespace Server.Data
{
    public class GremmerContext : DbContext
    {

        #region Debtors
        public virtual DbSet<Debtor> Debtors { get; set; }
        public virtual DbSet<DebtorInvoice> DebtorInvoices { get; set; }
        public virtual DbSet<Reminder> Reminders { get; set; }
        #endregion

        #region Creditors
        public virtual DbSet<Creditor> Creditors { get; set; }
        public virtual DbSet<CreditorInvoice> CreditorInvoices { get; set; }
        #endregion

        #region Registration
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Subscription> Subscriptions { get; set; }
        public virtual DbSet<User> User { get; set; }
        #endregion

        #region Settings
        public virtual DbSet<LoginSettings> LoginSettingsSet { get; set; }
        public virtual DbSet<MonetarySettings> MonetarySettingsSet { get; set; }
        #endregion

    }
}
