using System;
using System.Collections.Generic;
using System.Text;

namespace Watchables.Model
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Duration { get; set; }
        public decimal Rating { get; set; }
        public string Description { get; set; }
        public string Cast { get; set; }
        public string TrailerLink { get; set; }
        public string ImageLink { get; set; }
        public bool Standalone { get; set; }
        public decimal Price { get; set; }
    }
}
