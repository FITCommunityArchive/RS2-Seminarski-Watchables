using System;
using System.Collections.Generic;
using System.Text;

namespace Watchables.Model
{
    public class UsersShows
    {
        public int UserId { get; set; }
        public int ShowId { get; set; }
        public DateTime PurchaseDate { get; set; }
        public decimal PurchaseAmount { get; set; }
    }
}
