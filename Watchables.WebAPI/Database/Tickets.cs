using System;
using System.Collections.Generic;

namespace Watchables.WebAPI.Database
{
    public partial class Tickets
    {
        public int TicketId { get; set; }
        public DateTime DateTime { get; set; }
        public string Seat { get; set; }
        public int OrderId { get; set; }

        public virtual Orders Order { get; set; }
    }
}
