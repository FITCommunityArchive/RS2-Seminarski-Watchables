﻿using System;
using System.Collections.Generic;

namespace Watchables.WebAPI.Database
{
    public partial class Cinemas
    {
        public Cinemas()
        {
            AiringDaysOfCinema = new HashSet<AiringDaysOfCinema>();
            CinemaProducts = new HashSet<CinemaProducts>();
            Hall = new HashSet<Hall>();
        }

        public int CinemaId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Location { get; set; }
        public int StreetNumber { get; set; }
        public string PhoneNumber { get; set; }
        public decimal Rating { get; set; }
        public string Description { get; set; }
        public string ImageLink { get; set; }

        public virtual ICollection<AiringDaysOfCinema> AiringDaysOfCinema { get; set; }
        public virtual ICollection<CinemaProducts> CinemaProducts { get; set; }
        public virtual ICollection<Hall> Hall { get; set; }
    }
}
