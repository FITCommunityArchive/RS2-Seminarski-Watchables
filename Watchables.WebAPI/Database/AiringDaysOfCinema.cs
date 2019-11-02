using System;
using System.Collections.Generic;

namespace Watchables.WebAPI.Database
{
    public partial class AiringDaysOfCinema
    {
        public AiringDaysOfCinema()
        {
            CinemaDayMovie = new HashSet<CinemaDayMovie>();
        }

        public int AiringDaysOfCinemaId { get; set; }
        public int CinemaId { get; set; }
        public int AiringDayId { get; set; }

        public virtual AiringDays AiringDay { get; set; }
        public virtual Cinemas Cinema { get; set; }
        public virtual ICollection<CinemaDayMovie> CinemaDayMovie { get; set; }
    }
}
