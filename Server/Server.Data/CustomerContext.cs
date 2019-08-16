using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Server.Data.Entities.Creditors;
using Server.Data.Entities.Debtors;
using Server.Data.Entities.Registration;
using Server.Data.Entities.Settings;

namespace Server.Data
{
    /// <summary>
    /// Contains all DbSets 
    /// </summary>
    public class CustomerContext : DbContext 
    {

        #region Debtors
        public virtual DbSet<Debtor> Debtors { get; set; }
        public virtual DbSet<SalesInvoice> SalesInvoices { get; set; }
        public virtual DbSet<Reminder> Reminders { get; set; }
        #endregion

        #region Creditors
        public virtual DbSet<Creditor> Creditors { get; set; }
        public virtual DbSet<PurchaseInvoice> PurchaseInvoices { get; set; }
        #endregion

        #region Registration
        public virtual DbSet<BusinessUnit> BusinessUnits { get; set; }
        public virtual DbSet<User> User { get; set; }
        #endregion

        #region Settings
        public virtual DbSet<LoginSettings> LoginSettings { get; set; }
        public virtual DbSet<MonetarySettings> MonetarySettings { get; set; }
        #endregion

    }
}
