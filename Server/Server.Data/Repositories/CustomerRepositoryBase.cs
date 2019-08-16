using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Data.Repositories
{
    public class CustomerRepositoryBase
    {
        protected CustomerRepositoryBase(CustomerContext context)
        {
            CustomerContext = context;
        }

        protected internal CustomerContext CustomerContext { get; }
    }
}
