using System;
using System.Collections.Generic;

namespace Watchables.WebAPI.Database
{
    public partial class UsersSubscriptions
    {
        public int UserId { get; set; }
        public int SubscriptionId { get; set; }
        public DateTime SubscriptionDate { get; set; }

        public virtual Subscriptions Subscription { get; set; }
        public virtual Users User { get; set; }
    }
}
