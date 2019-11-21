using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Watchables.Model.Requests
{
    public class InsertMovieRequest
    {
        [Required]
        [MinLength(4)]
        public string Title { get; set; }

        [Required]
        [Range(1800, 2025)]
        public int Year { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:HH:mm}")]
        [RegularExpression("^(?:0?[0-9]|1[0-9]|2[0-3]):[0-5][0-9]$")]
        public string Duration { get; set; }

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
        public bool Standalone { get; set; }

        [Required]
        [Range(1, 200)]
        public decimal Price { get; set; }

        [Required]
        [MinLength(4)]
        public string Genre { get; set; }
    }
}
