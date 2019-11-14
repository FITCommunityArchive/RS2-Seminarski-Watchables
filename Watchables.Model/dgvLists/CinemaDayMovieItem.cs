using System;
using System.Collections.Generic;
using System.Text;

namespace Watchables.Model.dgvLists
{
    public class CinemaDayMovieItem
    {
        public int CinemaDayMovieId { get; set; }
        public int MovieId { get; set; }
        public string Movie { get; set; }
        public int NumberOfAppointments { get; set; }
    }
}
