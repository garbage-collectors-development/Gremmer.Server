using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Server.Data.Entities.Registration
{
    public class SubscriptionType
    {
        [Key] public int Id { get; set; }

        public string Name { get; set; }

        public int Rights { get; set; }
    }
}
