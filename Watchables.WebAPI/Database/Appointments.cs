using System;
using System.Collections.Generic;

namespace Watchables.WebAPI.Database
{
    public partial class Appointments
    {
        public Appointments()
        {
            Orders = new HashSet<Orders>();
        }

        public int AppointmentId { get; set; }
        public decimal Price { get; set; }
        public string StartsAt { get; set; }
        public int SoldSeats { get; set; }
        public int CinemaDayMovieId { get; set; }
        public int HallId { get; set; }

        public virtual CinemaDayMovie CinemaDayMovie { get; set; }
        public virtual Hall Hall { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
