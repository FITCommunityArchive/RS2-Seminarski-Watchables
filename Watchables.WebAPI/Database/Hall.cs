using System;
using System.Collections.Generic;

namespace Watchables.WebAPI.Database
{
    public partial class Hall
    {
        public Hall()
        {
            Appointments = new HashSet<Appointments>();
        }

        public int HallId { get; set; }
        public string HallName { get; set; }
        public int HallNumber { get; set; }
        public int NumberOfseats { get; set; }
        public int CinemaId { get; set; }

        public virtual Cinemas Cinema { get; set; }
        public virtual ICollection<Appointments> Appointments { get; set; }
    }
}
