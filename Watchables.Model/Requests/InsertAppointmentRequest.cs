using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Watchables.Model.Requests
{
    public class InsertAppointmentRequest
    {
        [Required]
        [Range(1, 100)]
        public decimal Price { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:HH:mm}")]
        [RegularExpression("^(?:0?[0-9]|1[0-9]|2[0-3]):[0-5][0-9]$")]
        public string StartsAt { get; set; }

        [Range(0, 0, ErrorMessage = "A new appointment must have 0 seats to begin with")]
        public int SoldSeats { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter valid integer number for CinemaDayMovieId")]
        public int CinemaDayMovieId { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter valid integer number for HallId")]
        public int HallId { get; set; }
    }
}
