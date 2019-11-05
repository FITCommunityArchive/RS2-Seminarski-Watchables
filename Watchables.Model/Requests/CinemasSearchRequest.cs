using System;
using System.Collections.Generic;
using System.Text;

namespace Watchables.Model.Requests
{
    public class CinemasSearchRequest
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Location { get; set; }
        public decimal Rating { get; set; }
    }
}
