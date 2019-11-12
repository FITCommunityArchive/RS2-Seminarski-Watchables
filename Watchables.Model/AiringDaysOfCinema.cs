using System;
using System.Collections.Generic;
using System.Text;

namespace Watchables.Model
{
    public class AiringDaysOfCinema
    {
        public int AiringDaysOfCinemaId { get; set; }
        public int CinemaId { get; set; }
        public int AiringDayId { get; set; }
        public DateTime Date { get; set; }
    }
}
