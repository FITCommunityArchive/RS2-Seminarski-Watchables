using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Watchables.Model
{
    public class Hall
    {
        public int HallId { get; set; }
        [Required]
        [MinLength(4)]
        public string HallName { get; set; }

        [Required]
        [Range(1, 100)]
        public int HallNumber { get; set; }

        [Required]
        [Range(1, 100)]
        public int NumberOfseats { get; set; }

        public int CinemaId { get; set; }
    }
}
