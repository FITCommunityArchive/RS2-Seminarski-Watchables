using System;
using System.Collections.Generic;
using System.Text;

namespace Watchables.Model.Requests
{
    public class ShowSearchRequest
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public decimal Rating { get; set; }
        public string Ongoing { get; set; }
        public string Genre { get; set; }
    }
}
