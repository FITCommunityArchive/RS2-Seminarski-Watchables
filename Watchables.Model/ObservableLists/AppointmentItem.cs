using System;
using System.Collections.Generic;
using System.Text;

namespace Watchables.Model.ObservableLists
{
    public class AppointmentItem {
        public int AppId { get; set; }
        public string StartsAt { get; set; }
        public string HallName { get; set; }
        public int HallNumber { get; set; }
        public int HallId { get; set; }
        public int SoldSeats { get; set; }
        public bool Full { get; set; }
        public decimal Price { get; set; }
        public string Display { get; set; }
        public int HallNumberOfSeats{get; set;}
    }
}
