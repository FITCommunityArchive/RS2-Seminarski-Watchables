using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Watchables.Model
{
    public class Show
    {
        public int ShowId { get; set; }
        [Required]
        [MinLength(4)]
        public string Title { get; set; }

        [Required]
        [Range(1800, 2025)]
        public int Year { get; set; }

        [Required]
        [Range(1, 100)]
        public int NumberOfSeasons { get; set; }

        [Required]
        [Range(0, 10)]
        public decimal Rating { get; set; }

        [Required]
        [MinLength(5)]
        public string Description { get; set; }

        [Required]
        [MinLength(15)]
        public string Cast { get; set; }
        
        [Required]
        public string TrailerLink { get; set; }

        [Required]
        public string ImageLink { get; set; }

        [Required]
        [Range(1, 200)]
        public decimal Price { get; set; }

        [Required]
        public bool Ongoing { get; set; }

        [Required]
        [MinLength(4)]
        public string Genre { get; set; }
    }
}
