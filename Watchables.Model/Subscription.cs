using System;
using System.Collections.Generic;
using System.Text;

namespace Watchables.Model
{
    public class Subscription
    {
        public int SubscriptionId { get; set; }
        public int NumberOfMovies { get; set; }
        public int NumberOfShows { get; set; }
        public int NumberOfTickets { get; set; }
        public decimal Price { get; set; }
        public bool Available { get; set; }
    }
}
