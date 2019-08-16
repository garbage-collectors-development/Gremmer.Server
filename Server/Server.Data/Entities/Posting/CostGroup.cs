using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Data.Entities.Posting
{
    /// <summary>
    /// A cost group's only purpose is to show the different type of costs.
    /// Those groups are not shown on the income statement. Only the general ledger accounts are used in this statement.
    /// Cost groups are often (though not necessarily) added to columns of invoices or posts to divide the costs into groups and get structured financial data or select on specific traits.
    /// </summary>
    public class CostGroup
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public string Description { get; set; }
    }
}
