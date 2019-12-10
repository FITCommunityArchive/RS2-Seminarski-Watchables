using System;
using System.Collections.Generic;
using System.Text;

namespace Watchables.Model
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public DateTime DateTime { get; set; }
        public string Seat { get; set; }
        public int OrderId { get; set; }
    }
}
