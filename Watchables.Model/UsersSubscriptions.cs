using System;
using System.Collections.Generic;
using System.Text;

namespace Watchables.Model
{
    public class UsersSubscriptions
    {
        public int UserId { get; set; }
        public int SubscriptionId { get; set; }
        public DateTime SubscriptionDate { get; set; }
    }
}
