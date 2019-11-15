using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Watchables.Model
{
    public class CinemaDayMovie
    {
        public int CinemaDayMovieId { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter valid integer number for airingDaysOfCinemaId")]
        public int AiringDaysOfCinemaId { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter valid integer number for movieId")]
        public int MovieId { get; set; }
    }
}
