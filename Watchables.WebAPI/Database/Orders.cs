using System;
using System.Collections.Generic;

namespace Watchables.WebAPI.Database
{
    public partial class Orders
    {
        public Orders()
        {
            OrderProducts = new HashSet<OrderProducts>();
            Tickets = new HashSet<Tickets>();
        }

        public int OrderId { get; set; }
        public decimal Total { get; set; }
        public int AppointmentId { get; set; }
        public int UserId { get; set; }

        public virtual Appointments Appointment { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<OrderProducts> OrderProducts { get; set; }
        public virtual ICollection<Tickets> Tickets { get; set; }
    }
}
