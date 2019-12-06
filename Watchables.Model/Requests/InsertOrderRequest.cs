using System;
using System.Collections.Generic;
using System.Text;

namespace Watchables.Model.Requests
{
    public class InsertOrderRequest
    {
        public int AppointmentId { get; set; }
        public int UserId { get; set; }
        public int NumberOfTickets { get; set; }
        public List<Model.Product> Products { get; set; }
    }
}
