using System;
using System.Collections.Generic;

namespace Watchables.WebAPI.Database
{
    public partial class CinemaDayMovie
    {
        public CinemaDayMovie()
        {
            Appointments = new HashSet<Appointments>();
        }

        public int CinemaDayMovieId { get; set; }
        public int AiringDaysOfCinemaId { get; set; }
        public int MovieId { get; set; }

        public virtual AiringDaysOfCinema AiringDaysOfCinema { get; set; }
        public virtual Movies Movie { get; set; }
        public virtual ICollection<Appointments> Appointments { get; set; }
    }
}
