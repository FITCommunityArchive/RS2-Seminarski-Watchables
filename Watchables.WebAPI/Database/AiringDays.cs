using System;
using System.Collections.Generic;

namespace Watchables.WebAPI.Database
{
    public partial class AiringDays
    {
        public AiringDays()
        {
            AiringDaysOfCinema = new HashSet<AiringDaysOfCinema>();
        }

        public int AiringDayId { get; set; }
        public string Name { get; set; }
        public string StartsAt { get; set; }
        public string EndsAt { get; set; }

        public virtual ICollection<AiringDaysOfCinema> AiringDaysOfCinema { get; set; }
    }
}
