using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace SerwisSubskrypcja.Models
{
    public class SubscriptionContext : DbContext
    {
        public SubscriptionContext() : base("SerwisSubskrypcja")
        {

        }

        public DbSet<Subscriber> Subscribers { get; set; }
    }
}