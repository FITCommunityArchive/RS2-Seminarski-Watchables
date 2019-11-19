using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Watchables.Model.Requests
{
    public class InserAiringDayOfCinemaRequest
    {
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter valid integer number for cinemaId")]
        public int CinemaId { get; set; }
        [Required]
        public DateTime Date { get; set; }
    }
}
