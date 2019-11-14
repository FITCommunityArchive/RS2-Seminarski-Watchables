using System;
using System.Collections.Generic;
using System.Text;

namespace Watchables.Model.Requests
{
    public class CinemasScheduleRequest
    {
        public Cinema Cinema { get; set; }
        public List<Model.AiringDay> AiringDays { get; set; }
        public List<Model.AiringDaysOfCinema> AiringDaysOfCinema { get; set; }
        public List<Model.CinemaDayMovie> CinemaDayMovies { get; set; }
        public List<Model.Appointments> Appointments { get; set; }
        public List<Model.Movie> Movies { get; set; }
        public List<Model.Hall> Halls { get; set; }
    }
}
