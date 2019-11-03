using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Watchables.Model
{
    public class Cinema
    {

        public int CinemaId { get; set; }
        [Required]
        [MinLength(4)]
        public string Name { get; set; }

        [Required]
        [MinLength(5)]
        public string Address { get; set; }

        [Required]
        [MinLength(4)]
        public string Location { get; set; }

        [Required]
        [Range(1, 100)]
        public int StreetNumber { get; set; }

        [Required]
        [MinLength(9)]
        public string PhoneNumber { get; set; }

        [Range(1, 5)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Rating { get; set; }

        [Required]
        [MinLength(5)]
        public string Description { get; set; }

        [Required]
        public string ImageLink { get; set; }
        
    }
}
