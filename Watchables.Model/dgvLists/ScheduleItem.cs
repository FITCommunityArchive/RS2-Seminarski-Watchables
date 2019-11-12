using System;
using System.Collections.Generic;
using System.Text;

namespace Watchables.Model.dgvLists
{
    public class ScheduleItem
    {
        public int AiringDaysOfCinemasId { get; set; }
        public DateTime Date { get; set; }
        public string Day { get; set; }
        public int NumberOfMovies { get; set; }
    }
}
