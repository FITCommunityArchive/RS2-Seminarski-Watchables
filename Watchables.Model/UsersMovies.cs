using System;
using System.Collections.Generic;
using System.Text;

namespace Watchables.Model
{
    public class UsersMovies
    {
        public int UserId { get; set; }
        public int MovieId { get; set; }
        public DateTime PurchaseDate { get; set; }
        public decimal PurchaseAmount { get; set; }
    }
}
