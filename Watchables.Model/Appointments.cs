using System;
using System.Collections.Generic;
using System.Text;

namespace Watchables.Model
{
    public class Appointments
    {
        public int AppointmentId { get; set; }
        public decimal Price { get; set; }
        public string StartsAt { get; set; }
        public int SoldSeats { get; set; }
        public int CinemaDayMovieId { get; set; }
        public int HallId { get; set; }
    }
}
