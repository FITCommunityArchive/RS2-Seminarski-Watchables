using System;
using System.Collections.Generic;

namespace Watchables.WebAPI.Database
{
    public partial class Shows
    {
        public Shows()
        {
            Rotations = new HashSet<Rotations>();
            UsersShows = new HashSet<UsersShows>();
        }

        public int ShowId { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public int NumberOfSeasons { get; set; }
        public decimal Rating { get; set; }
        public string Description { get; set; }
        public string Cast { get; set; }
        public string TrailerLink { get; set; }
        public string ImageLink { get; set; }
        public decimal Price { get; set; }
        public bool Ongoing { get; set; }

        public virtual ICollection<Rotations> Rotations { get; set; }
        public virtual ICollection<UsersShows> UsersShows { get; set; }
    }
}
