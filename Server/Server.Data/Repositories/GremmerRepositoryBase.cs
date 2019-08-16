using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Data.Repositories
{
    public abstract class GremmerRepositoryBase
    {
        protected GremmerRepositoryBase(GremmerContext context)
        {
            GremmerContext = context;
        }

        protected internal GremmerContext GremmerContext { get; }
    }
}
