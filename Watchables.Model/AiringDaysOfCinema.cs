using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Watchables.Model
{
    public class AiringDaysOfCinema
    {
        public int AiringDaysOfCinemaId { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter valid integer number for cinemaId")]
        public int CinemaId { get; set; }
        [Required]
        [Range(0,7)]
        public int AiringDayId { get; set; }
        [Required]   
        public DateTime Date { get; set; }
    }
}
