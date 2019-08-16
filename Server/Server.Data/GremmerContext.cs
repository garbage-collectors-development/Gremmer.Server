using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Server.Data.Entities.Registration;

namespace Server.Data
{
    public class GremmerContext : DbContext
    {
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Subscription> Subscriptions { get; set; }

    }
}
