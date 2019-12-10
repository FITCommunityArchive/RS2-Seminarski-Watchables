using System;
using System.Collections.Generic;
using System.Text;

namespace Watchables.Model
{
    public class Order
    {
        public int OrderId { get; set; }
        public decimal Total { get; set; }
        public int AppointmentId { get; set; }
        public int UserId { get; set; }
        public List<Model.Ticket> Tickets { get; set; }
    }
}
