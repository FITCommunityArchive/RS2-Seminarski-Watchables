using System;
using System.Collections.Generic;
using System.Text;

namespace Watchables.Model.Requests
{
    public class InsertCinemaRequest
    {
        public Cinema Cinema { get; set; }
        public List<Hall> Halls { get; set; }
        public List<Product> Products { get; set; }

    }
}
