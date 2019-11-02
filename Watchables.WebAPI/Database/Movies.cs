using System;
using System.Collections.Generic;

namespace Watchables.WebAPI.Database
{
    public partial class Movies
    {
        public Movies()
        {
            CinemaDayMovie = new HashSet<CinemaDayMovie>();
            Rotations = new HashSet<Rotations>();
            UsersMovies = new HashSet<UsersMovies>();
        }

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

        public virtual ICollection<CinemaDayMovie> CinemaDayMovie { get; set; }
        public virtual ICollection<Rotations> Rotations { get; set; }
        public virtual ICollection<UsersMovies> UsersMovies { get; set; }
    }
}
