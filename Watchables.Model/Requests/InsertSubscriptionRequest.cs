using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Watchables.Model.Requests
{
    public class InsertSubscriptionRequest
    {
        [Required]
        [Range(1,10)]
        public int NumberOfMovies { get; set; }

        [Required]
        [Range(1, 10)]
        public int NumberOfShows { get; set; }

        [Required]
        [Range(1, 10)]
        public int NumberOfTickets { get; set; }

        [Required]
        [Range(1, 200)]
        public decimal Price { get; set; }

        [Required]
        public bool Available { get; set; }
    }
}
