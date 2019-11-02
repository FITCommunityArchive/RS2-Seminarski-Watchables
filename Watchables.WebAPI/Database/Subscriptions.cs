using System;
using System.Collections.Generic;

namespace Watchables.WebAPI.Database
{
    public partial class Subscriptions
    {
        public Subscriptions()
        {
            UsersSubscriptions = new HashSet<UsersSubscriptions>();
        }

        public int SubscriptionId { get; set; }
        public int NumberOfMovies { get; set; }
        public int NumberOfShows { get; set; }
        public int NumberOfTickets { get; set; }
        public decimal Price { get; set; }

        public virtual ICollection<UsersSubscriptions> UsersSubscriptions { get; set; }
    }
}
