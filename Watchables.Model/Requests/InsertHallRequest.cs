using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Watchables.Model.Requests
{
    public class InsertHallRequest
    {
        [Required]
        [MinLength(4)]
        public string HallName { get; set; }

        [Required]
        [Range(1, 100)]
        public int HallNumber { get; set; }

        [Required]
        [Range(1, 100)]
        public int NumberOfseats { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter valid integer number for cinemaId")]
        public int CinemaId { get; set; }
    }
}
