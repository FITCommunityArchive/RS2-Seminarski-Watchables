using System;
using System.Collections.Generic;
using System.Text;

namespace Watchables.Model.Requests
{
    public class MovieSearchRequest
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public decimal Rating { get; set; }
        public string Standalone { get; set; }
    }
}
