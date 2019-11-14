using System;
using System.Collections.Generic;
using System.Text;

namespace Watchables.Model.dgvLists
{
    public class AppointmentItem
    {
        public int AppointmentId { get; set; }
        public int HallId { get; set; }
        public string StartsAt { get; set; }
        public decimal Price { get; set; }
        public int SoldSeats { get; set; }
        public string Hall { get; set; }
        public string MovieDuration { get; set; }
        public string EndsAt { get; set; }
        public int HallSeats { get; set; }
    }
}
